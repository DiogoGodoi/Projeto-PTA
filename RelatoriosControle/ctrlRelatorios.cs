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
        public bool gerarRelatorioMovimentacao(string caminho, DataTable query)
        {
            Document document = new Document(PageSize.A4);
            document.SetMargins(3, 2 ,3 ,2);
            document.AddCreationDate();
            PdfWriter.GetInstance(document, new
            FileStream(caminho ,FileMode.Create));

            PdfPTable tabela = new PdfPTable(6);
            Font fonte = FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 12);

            document.Open();

            DataTable dados = query;

            Paragraph header = new Paragraph("Historico de Movimentação", fonte);
            header.Alignment = Element.ALIGN_CENTER;
            document.Add(header);

            Paragraph section = new Paragraph();
            section.Add(new Paragraph(" "));
            document.Add(section);

            Paragraph coluna1 = new Paragraph("Data", fonte);
            coluna1.Alignment = Element.ALIGN_CENTER;
            Paragraph coluna2 = new Paragraph("Item", fonte);
            coluna2.Alignment = Element.ALIGN_CENTER;
            Paragraph coluna3 = new Paragraph("Quantidade", fonte);
            coluna3.Alignment = Element.ALIGN_CENTER;
            Paragraph coluna4 = new Paragraph("Natureza", fonte);
            coluna4.Alignment = Element.ALIGN_CENTER;
            Paragraph coluna5 = new Paragraph("Operador", fonte);
            coluna5.Alignment = Element.ALIGN_CENTER;
            Paragraph coluna6 = new Paragraph("Requisitante", fonte);
            coluna6.Alignment = Element.ALIGN_CENTER;

            PdfPCell coll1 = new PdfPCell();
            PdfPCell coll2 = new PdfPCell();
            PdfPCell coll3 = new PdfPCell();
            PdfPCell coll4 = new PdfPCell();
            PdfPCell coll5 = new PdfPCell();
            PdfPCell coll6 = new PdfPCell();

            coll1.AddElement(coluna1);
            coll2.AddElement(coluna2);
            coll3.AddElement(coluna3);
            coll4.AddElement(coluna4);
            coll5.AddElement(coluna5);
            coll6.AddElement(coluna6);

            tabela.AddCell(coll1);
            tabela.AddCell(coll2);
            tabela.AddCell(coll3);
            tabela.AddCell(coll4);
            tabela.AddCell(coll5);
            tabela.AddCell(coll6);

            for (int i = 0; i < dados.Rows.Count; i++)
            {

                string item = dados.Rows[i]["item"].ToString();
                string quantidade = dados.Rows[i]["quantidade"].ToString();
                string dataModificacao = dados.Rows[i]["dataModificacao"].ToString();

                var dt = Convert.ToDateTime(dataModificacao);
                var dia = dt.ToString("dd/MM/yyyy");
                                   

                string natureza = dados.Rows[i]["natureza"].ToString();
                string operador = dados.Rows[i]["operador"].ToString();
                string requisitante = dados.Rows[i]["requisitante"].ToString();

                Font font = FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 8);

                Paragraph paragrafo1 = new Paragraph(dia, font);
                Phrase data = new Phrase(paragrafo1);
                PdfPCell celula1 = new PdfPCell(data);
                celula1.HorizontalAlignment = Element.ALIGN_CENTER;
                celula1.VerticalAlignment = Element.ALIGN_CENTER;
                tabela.AddCell(celula1);

                Paragraph paragrafo2 = new Paragraph(item, font);
                Phrase material = new Phrase(paragrafo2);
                PdfPCell celula2 = new PdfPCell(material);
                celula2.HorizontalAlignment = Element.ALIGN_CENTER;
                celula2.VerticalAlignment = Element.ALIGN_CENTER;
                tabela.AddCell(celula2);

                Paragraph paragrafo3 = new Paragraph(quantidade, font);
                paragrafo3.Alignment = Element.ALIGN_CENTER;
                Phrase quanti = new Phrase(paragrafo3);
                PdfPCell celula3 = new PdfPCell(quanti);
                celula3.HorizontalAlignment = Element.ALIGN_CENTER;
                celula3.VerticalAlignment = Element.ALIGN_CENTER;
                tabela.AddCell(celula3);

                Paragraph paragrafo4 = new Paragraph(natureza, font);
                paragrafo4.Alignment = Element.ALIGN_CENTER;
                Phrase natu = new Phrase(paragrafo4);
                PdfPCell celula4 = new PdfPCell(natu);
                celula4.HorizontalAlignment = Element.ALIGN_CENTER;
                celula4.VerticalAlignment = Element.ALIGN_CENTER;
                tabela.AddCell(celula4);

                Paragraph paragrafo5 = new Paragraph(operador, font);
                paragrafo5.Alignment = Element.ALIGN_CENTER;
                Phrase op = new Phrase(paragrafo5);
                PdfPCell celula5 = new PdfPCell(op);
                celula5.HorizontalAlignment = Element.ALIGN_CENTER;
                celula5.VerticalAlignment = Element.ALIGN_CENTER;
                tabela.AddCell(celula5);

                Paragraph paragrafo6 = new Paragraph(requisitante, font);
                paragrafo6.Alignment = Element.ALIGN_CENTER;
                Phrase req = new Phrase(paragrafo6);
                PdfPCell celula6 = new PdfPCell(req);
                celula6.HorizontalAlignment = Element.ALIGN_CENTER;
                celula6.VerticalAlignment = Element.ALIGN_CENTER;
                tabela.AddCell(celula6);

            }
            document.Add(tabela);
            document.Close();

            return true;
        }
    }
}
