using System;

namespace ObjetoPorta
{
    class Porta
    {

        static void main(string[] args)
        {

            
            private int id;
            private bool aberta;
            private string cor;

            private double dimensaoX, dimensaoY, dimensaoZ;

            public Porta()
            {

            }

            public int getId()
            {
                return id;
            }

            public bool getAberta()
            {
                return aberta;
            }

            public string getCor()
            {
                return cor;
            }

            public void setId(int id)
            {
                this.id = id;
            }

            public void setAberta(bool aberta)
            {
                this.aberta = aberta;
            }

            public void setCor(string cor)
            {
                this.cor = cor;
            }

            public double getDimensaoX()
            {
                return dimensaoX;
            }


            public double getDimensaoY()
            {
                return dimensaoY;
            }

            public double getDimensaoZ()
            {
                return dimensaoZ;
            }

            public void setDimensaoX(double dimensaoX)
            {
                this.dimensaoX = dimensaoX;
            }

            public void setDimensaoY(double dimensaoY)
            {
                this.dimensaoY = dimensaoY;
            }

            public void setDimensaoZ(double dimensaoZ)
            {
                this.dimensaoZ = dimensaoZ;
            }

            public void abre()
            {
                Console.WriteLine("\n Abrindo porta!");
                setAberta(true);
            }

            public void fecha()
            {

                Console.WriteLine("\n Fechando porta!");
                setAberta(false);
            }

            public void pinta(String s)
            {
                setCor(s);
                Console.WriteLine("Pintando a porta de " + getCor());
            }

            public Boolean estaAberta()
            {
                if (getAberta() == true)
                {
                    return true;
                    // Console.WriteLine("A porta está aberta!");
                }
                return false;
                // Console.WriteLine("A porta não está aberta!");
            }



        }
    }
}

