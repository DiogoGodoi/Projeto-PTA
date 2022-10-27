using HistoricoControle;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using HistoricoControle;

namespace RelatoriosControle
{
    
    public class ctrlRelatorios
    {


        public bool gerarRelatorioMovimentacao()
        {
            ctrlHistorico _ctrHistorico = new ctrlHistorico();
            Document document = new Document(PageSize.A4);
            document.SetMargins(40, 40, 40, 80);
            document.AddCreationDate();
            string caminho = @"C:\Users\infra\Desktop\" + "CONTRATO.pdf";
            PdfWriter writer = PdfWriter.GetInstance(document, new
            FileStream(caminho, FileMode.Create));

            document.Open();

            DataTable dados = _ctrHistorico.ExibirHistorico();

            Paragraph paragrafo = new Paragraph();
            paragrafo.Add("HISTORICO DE MOVIMENTAÇÃO");
            paragrafo.Add(new Paragraph(""));

            for (int i = 0; i < dados.Rows.Count; i++)
            {
                paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                string item = dados.Rows[i]["item"].ToString();
                string quantidade = dados.Rows[i]["quantidade"].ToString();
                string dataModificacao = dados.Rows[i]["dataModificacao"].ToString();
                string natureza = dados.Rows[i]["natureza"].ToString();
                string operador = dados.Rows[i]["operador"].ToString();
                string requisitante = dados.Rows[i]["requisitante"].ToString();

                paragrafo.Add("----------------------------");
                paragrafo.Add(new Paragraph(""));
                paragrafo.Add("DATA: " + dataModificacao);
                paragrafo.Add(new Paragraph(""));
                paragrafo.Add("ITEM: " + item);
                paragrafo.Add(new Paragraph(""));
                paragrafo.Add("QUANTIDADE: " + quantidade);
                paragrafo.Add(new Paragraph(""));
                paragrafo.Add("NATUREZA: " + natureza);
                paragrafo.Add(new Paragraph(""));
                paragrafo.Add("OPERADOR: " + operador);
                paragrafo.Add(new Paragraph(""));
                paragrafo.Add("REQUISITANTE: " + requisitante);
                paragrafo.Add(new Paragraph(""));
            }
            document.Add(paragrafo);
            document.Close();

            return true;
        }
    }
}
