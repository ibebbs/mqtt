﻿using System;
using System.Collections.Generic;
using System.Linq;
using Hermes.Messages;
using Hermes.Properties;

namespace Hermes.Formatters
{
	public class SubscribeAckFormatter : Formatter<SubscribeAck>
	{
		public SubscribeAckFormatter (IChannel<IMessage> reader, IChannel<byte[]> writer)
			: base(reader, writer)
		{
		}

		public override MessageType MessageType { get { return Messages.MessageType.SubscribeAck; } }

		protected override SubscribeAck Read (byte[] packet)
		{
			this.ValidateHeaderFlag (packet, t => t == MessageType.SubscribeAck, 0x00);

			var remainingLengthBytesLength = 0;
			var remainingLength = Protocol.Encoding.DecodeRemainingLength (packet, out remainingLengthBytesLength);

			var packetIdentifierStartIndex = remainingLengthBytesLength + 1;
			var packetIdentifier = packet.Bytes (packetIdentifierStartIndex, 2).ToUInt16();

			var headerLength = 1 + remainingLengthBytesLength + 2;
			var returnCodeBytes = packet.Bytes(headerLength);

			if(!returnCodeBytes.Any())
				throw new ViolationProtocolException(Resources.SubscribeAckFormatter_MissingReturnCodes);

			if (returnCodeBytes.Any (b => !Enum.IsDefined (typeof (SubscribeReturnCode), b)))
				throw new ViolationProtocolException (Resources.SubscribeAckFormatter_InvalidReturnCodes);
				
			var returnCodes = returnCodeBytes.Select(b => (SubscribeReturnCode)b).ToArray();

			return new SubscribeAck (packetIdentifier, returnCodes);
		}

		protected override byte[] Write (SubscribeAck message)
		{
			var packet = new List<byte> ();

			var variableHeader = this.GetVariableHeader (message);
			var payload = this.GetPayload (message);
			var remainingLength = Protocol.Encoding.EncodeRemainingLength (variableHeader.Length + payload.Length);
			var fixedHeader = this.GetFixedHeader (remainingLength);

			packet.AddRange (fixedHeader);
			packet.AddRange (variableHeader);
			packet.AddRange (payload);

			return packet.ToArray();
		}

		private byte[] GetFixedHeader(byte[] remainingLength)
		{
			var fixedHeader = new List<byte> ();

			var flags = 0x00;
			var type = Convert.ToInt32(MessageType.SubscribeAck) << 4;

			var fixedHeaderByte1 = Convert.ToByte(flags | type);

			fixedHeader.Add (fixedHeaderByte1);
			fixedHeader.AddRange (remainingLength);

			return fixedHeader.ToArray();
		}

		private byte[] GetVariableHeader(SubscribeAck message)
		{
			var variableHeader = new List<byte> ();

			var messageIdBytes = Protocol.Encoding.EncodeBigEndian(message.MessageId);

			variableHeader.AddRange (messageIdBytes);

			return variableHeader.ToArray();
		}

		private byte[] GetPayload(SubscribeAck message)
		{
			if(message.ReturnCodes == null || !message.ReturnCodes.Any())
				throw new ViolationProtocolException(Resources.SubscribeAckFormatter_MissingReturnCodes);

			return message.ReturnCodes
				.Select(c => Convert.ToByte(c))
				.ToArray();
		}
	}
}