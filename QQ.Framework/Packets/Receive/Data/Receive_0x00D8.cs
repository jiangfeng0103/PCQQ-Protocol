namespace QQ.Framework.Packets.Receive.Data
{
    public class Receive_0X00D8 : ReceivePacket
    {
        public Receive_0X00D8(byte[] byteBuffer, QQUser user)
            : base(byteBuffer, user, user.TXProtocol.SessionKey)
        {
        }

        protected override void ParseBody()
        {
            Decrypt(User.TXProtocol.SessionKey);
        }
    }
}