using System.Collections.Generic;
using System.Drawing;

namespace SysNorteGrupo.Utils
{
    public class Cores
    {
        public Color id_cor { get; set; }

        public string nome_cor { get; set; }

        public List<Cores> listaDeCores()
        {
            List<Cores> listCores = new List<Cores>();

            listCores.Add(new Cores() { id_cor = Color.FromArgb(245, 245, 220), nome_cor = "BEGE" });
            listCores.Add(new Cores() { id_cor = Color.FromArgb(0, 0, 0), nome_cor = "PRETO" });
            listCores.Add(new Cores() { id_cor = Color.FromArgb(0, 0, 255), nome_cor = "AZUL" });
            listCores.Add(new Cores() { id_cor = Color.FromArgb(255, 215, 0), nome_cor = "OURO" });
            listCores.Add(new Cores() { id_cor = Color.FromArgb(128, 128, 128), nome_cor = "CINZA" });
            listCores.Add(new Cores() { id_cor = Color.FromArgb(0, 128, 0), nome_cor = "VERDE" });
            listCores.Add(new Cores() { id_cor = Color.FromArgb(255, 105, 180), nome_cor = "ROSA ESCURO" });
            listCores.Add(new Cores() { id_cor = Color.FromArgb(128, 0, 0), nome_cor = "MARRON" });
            listCores.Add(new Cores() { id_cor = Color.FromArgb(255, 165, 0), nome_cor = "LARANJA" });
            listCores.Add(new Cores() { id_cor = Color.FromArgb(255, 192, 203), nome_cor = "ROSA" });
            listCores.Add(new Cores() { id_cor = Color.FromArgb(128, 0, 128), nome_cor = "ROXO" });
            listCores.Add(new Cores() { id_cor = Color.FromArgb(255, 0, 0), nome_cor = "VERMELHO" });
            listCores.Add(new Cores() { id_cor = Color.FromArgb(192, 192, 192), nome_cor = "SALMÃO" });
            listCores.Add(new Cores() { id_cor = Color.FromArgb(245, 245, 220), nome_cor = "PRATA" });
            listCores.Add(new Cores() { id_cor = Color.FromArgb(255, 99, 71), nome_cor = "TOMATE" });
            listCores.Add(new Cores() { id_cor = Color.FromArgb(238, 130, 238), nome_cor = "VIOLETA" });
            listCores.Add(new Cores() { id_cor = Color.FromArgb(255, 255, 255), nome_cor = "BRANCO" });
            listCores.Add(new Cores() { id_cor = Color.FromArgb(255, 255, 0), nome_cor = "AMARELO" });

            return listCores;
        }
    }
}
