namespace WebAPI.Controllers
{
    internal class SymmetricAlgorithmKey
    {
        private byte[] _Vs;

        public SymmetricAlgorithmKey(byte[] vs)
        {
            _Vs = vs;
        }
    }
}