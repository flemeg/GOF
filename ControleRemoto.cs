namespace GOF
{
    public interface IControleRemoto
    {
        void Play();
        void Pause();
    }

    public interface IControleSom : IControleRemoto
    {
        void MudarRadio();
    }

    public class Som : IControleSom
    {
        public void MudarRadio()
        {
            throw new System.NotImplementedException();
        }

        public void Pause()
        {
            throw new System.NotImplementedException();
        }

        public void Play()
        {
            throw new System.NotImplementedException();
        }
    }
}
