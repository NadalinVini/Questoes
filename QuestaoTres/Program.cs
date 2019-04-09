using NUnit.Framework;
using System;
using System.IO;

namespace QuestaoTres
{
    [TestFixture]
    public class Program
    {
        [Test]
        public void Main()
        {
            #region Cenario

            //Diretório com as fotos            
            string[] arquivo = Directory.GetFiles("C:\\Users\\User\\Downloads\\Fotos");

            //Diretório novo sem fotos.
            string path = @"C:\\ViniciusFotos";

            #endregion

            #region Acao

            //Criando Diretório
            DirectoryInfo di = Directory.CreateDirectory(path);
            var time = Directory.GetCreationTime(path);

            //Pegando o nome das fotosa e copiando para a nova pasta.
            foreach (var item in arquivo)
            {
                path = @"C:\\ViniciusFotos";

                string nomeDoArquivo = item.Split(new char[] { '\\' })[item.Split(new char[] { '\\' }).Length - 1];
                path = path + "\\" + nomeDoArquivo;

                //Realizando a copia
                File.Copy(item, path, true);
            }
            #endregion

            #region Validacao

            //Verifica Data de criação
            FileInfo infoArquivo = new FileInfo(@"C:\\ViniciusFotos");
            var timeCompare = infoArquivo.CreationTime;

            var diretorios = Directory.GetFiles(@"C:\\ViniciusFotos");

            Assert.AreEqual(diretorios.Length, 4);
            Assert.AreEqual(time, timeCompare);

            #endregion


        }
    }
}
