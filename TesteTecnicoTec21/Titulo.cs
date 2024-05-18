using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TesteTecnicoTec21
{
    [XmlRoot(ElementName = "Titulo")]
    public class Titulo
    {

        [XmlElement(ElementName = "Protocolo")]
        public int Protocolo { get; set; }

        [XmlElement(ElementName = "NomeDevedor")]
        public string NomeDevedor { get; set; }

        [XmlElement(ElementName = "DocumentoDevedor")]
        public string DocumentoDevedor { get; set; }

        [XmlElement(ElementName = "NomeApresentante")]
        public string NomeApresentante { get; set; }

        [XmlElement(ElementName = "DocumentoApresentante")]
        public string DocumentoApresentante { get; set; }

        [XmlElement(ElementName = "NomeCredor")]
        public string NomeCredor { get; set; }

        [XmlElement(ElementName = "DocumentoCredor")]
        public string DocumentoCredor { get; set; }

        [XmlElement(ElementName = "NumeroTitulo")]
        public int NumeroTitulo { get; set; }

        [XmlElement(ElementName = "ValorTitulo")]
        public double ValorTitulo { get; set; }

        [XmlElement(ElementName = "DataEmissao")]
        public DateTime DataEmissao { get; set; }

        [XmlElement(ElementName = "EspecieTitulo")]
        public string EspecieTitulo { get; set; }
    }

    [XmlRoot(ElementName = "Titulos")]
    public class Titulos
    {

        [XmlElement(ElementName = "Titulo")]
        public List<Titulo> Titulo { get; set; }

        
    }
}
