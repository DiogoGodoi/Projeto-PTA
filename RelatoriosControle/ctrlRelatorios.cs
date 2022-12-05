using HistoricoControle;
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
using Org.BouncyCastle.Bcpg.OpenPgp;
using SaidaControle;

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
            Font fonteBranca = FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 12);
            fonteBranca.Color = BaseColor.WHITE;

            document.Open();

            DataTable dados = query;

            Paragraph nav = new Paragraph();
            nav.Add(new Paragraph(" "));
            document.Add(nav);

            Image imgPdf = Image.GetInstance(@"C:\logoGaleria\índice.png");
            imgPdf.Alignment = Element.ALIGN_CENTER;
            document.Add(imgPdf);

            Paragraph nav1 = new Paragraph();
            nav1.Add(new Paragraph(" "));
            document.Add(nav1);

            Paragraph header = new Paragraph("Historico de Movimentação", fonte);
            header.Alignment = Element.ALIGN_CENTER;
            document.Add(header);

            Paragraph section = new Paragraph();
            section.Add(new Paragraph(" "));
            document.Add(section);

            Paragraph hCell = new Paragraph("Materiais", fonteBranca);
            hCell.Alignment = Element.ALIGN_CENTER;
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

            PdfPCell hColl = new PdfPCell();
            hColl.Colspan = 6;
            hColl.BackgroundColor = BaseColor.BLUE;
            PdfPCell coll1 = new PdfPCell();
            coll1.BackgroundColor = BaseColor.GRAY;
            PdfPCell coll2 = new PdfPCell();
            coll2.BackgroundColor = BaseColor.GRAY;
            PdfPCell coll3 = new PdfPCell();
            coll3.BackgroundColor = BaseColor.GRAY;
            PdfPCell coll4 = new PdfPCell();
            coll4.BackgroundColor = BaseColor.GRAY;
            PdfPCell coll5 = new PdfPCell();
            coll5.BackgroundColor = BaseColor.GRAY;
            PdfPCell coll6 = new PdfPCell();
            coll6.BackgroundColor = BaseColor.GRAY;

            hColl.AddElement(hCell);
            coll1.AddElement(coluna1);
            coll2.AddElement(coluna2);
            coll3.AddElement(coluna3);
            coll4.AddElement(coluna4);
            coll5.AddElement(coluna5);
            coll6.AddElement(coluna6);

            tabela.AddCell(hColl);
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
        public bool relatorioEstoqueMin(string caminho, DataTable query)
        {
            Document document = new Document(PageSize.A4);
            document.SetMargins(3, 2, 3, 2);
            document.AddCreationDate();
            PdfWriter.GetInstance(document, new
            FileStream(caminho, FileMode.Create));

            PdfPTable tabela = new PdfPTable(3);
            Font fonte = FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 12);
            Font fonteBranca = FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 12);
            fonteBranca.Color = BaseColor.WHITE;

            document.Open();

            DataTable dados = query;

            Paragraph nav = new Paragraph();
            nav.Add(new Paragraph(" "));
            document.Add(nav);

            Image imgPdf = Image.GetInstance(@"C:\logoGaleria\índice.png");
            imgPdf.Alignment = Element.ALIGN_CENTER;
            document.Add(imgPdf);

            Paragraph nav1 = new Paragraph();
            nav1.Add(new Paragraph(" "));
            document.Add(nav1);

            Paragraph header = new Paragraph("Itens com estoque minimo atingido", fonte);
            header.Alignment = Element.ALIGN_CENTER;
            document.Add(header);

            Paragraph section = new Paragraph();
            section.Add(new Paragraph(" "));
            document.Add(section);

            Paragraph hCell = new Paragraph("Item", fonteBranca);
            hCell.Alignment = Element.ALIGN_CENTER;
            Paragraph coluna1 = new Paragraph("Item", fonte);
            coluna1.Alignment = Element.ALIGN_CENTER;
            Paragraph coluna2 = new Paragraph("Quantidade Atual", fonte);
            coluna2.Alignment = Element.ALIGN_CENTER;
            Paragraph coluna3 = new Paragraph("Quantidade Minima", fonte);
            coluna3.Alignment = Element.ALIGN_CENTER;

            PdfPCell hColl = new PdfPCell();
            hColl.Colspan = 3;
            hColl.BackgroundColor = BaseColor.BLUE;
            PdfPCell coll1 = new PdfPCell();
            coll1.BackgroundColor = BaseColor.GRAY;
            PdfPCell coll2 = new PdfPCell();
            coll2.BackgroundColor = BaseColor.GRAY;
            PdfPCell coll3 = new PdfPCell();
            coll3.BackgroundColor = BaseColor.GRAY;

            hColl.AddElement(hCell);
            coll1.AddElement(coluna1);
            coll2.AddElement(coluna2);
            coll3.AddElement(coluna3);

            tabela.AddCell(hColl);
            tabela.AddCell(coll1);
            tabela.AddCell(coll2);
            tabela.AddCell(coll3);
            
            for (int i = 0; i < dados.Rows.Count; i++)
            {

                string item = dados.Rows[i]["nome"].ToString();
                string quantidade = dados.Rows[i]["quantidade"].ToString();
                string quantidadeMin = dados.Rows[i]["estoqueMin"].ToString();

                Font font = FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 8);

                Paragraph paragrafo1 = new Paragraph(item, font);
                Phrase itens = new Phrase(paragrafo1);
                PdfPCell celula1 = new PdfPCell(itens);
                celula1.HorizontalAlignment = Element.ALIGN_CENTER;
                celula1.VerticalAlignment = Element.ALIGN_CENTER;
                tabela.AddCell(celula1);

                Paragraph paragrafo2 = new Paragraph(quantidade, font);
                Phrase qtd = new Phrase(paragrafo2);
                PdfPCell celula2 = new PdfPCell(qtd);
                celula2.HorizontalAlignment = Element.ALIGN_CENTER;
                celula2.VerticalAlignment = Element.ALIGN_CENTER;
                tabela.AddCell(celula2);

                Paragraph paragrafo3 = new Paragraph(quantidadeMin, font);
                Phrase qtdMin = new Phrase(paragrafo3);
                PdfPCell celula3 = new PdfPCell(qtdMin);
                celula3.HorizontalAlignment = Element.ALIGN_CENTER;
                celula3.VerticalAlignment = Element.ALIGN_CENTER;
                tabela.AddCell(celula3);

            }
            document.Add(tabela);
            document.Close();

            return true;
        }
        public bool gerarRelatorioSaida(string titulo, string caminho, string requisitante, string pSetor, List<ctrlMovimentacao> list)
        {

            Document document = new Document(PageSize.A4);
            document.SetMargins(3, 2, 3, 2);
            document.AddCreationDate();
            PdfWriter.GetInstance(document, new
            FileStream(caminho, FileMode.Create));

            PdfPTable tabela = new PdfPTable(3);
            Font fonte = FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 12);
            Font fonteBranca = FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 12);
            fonteBranca.Color = BaseColor.WHITE;

            document.Open();

            Paragraph nav = new Paragraph();
            nav.Add(new Paragraph(" "));
            document.Add(nav);

            Image imgPdf = Image.GetInstance(@"C:\logoGaleria\índice.png");
            imgPdf.Alignment = Element.ALIGN_CENTER;
            document.Add(imgPdf);

            Paragraph nav1 = new Paragraph();
            nav1.Add(new Paragraph(" "));
            document.Add(nav1);

            Paragraph header = new Paragraph(titulo+" de materiais", fonte);
            header.Alignment = Element.ALIGN_CENTER;
            document.Add(header);

            Paragraph section = new Paragraph();
            section.Add(new Paragraph(" "));
            document.Add(section);

            Paragraph solicitante = new Paragraph("Requisitante: "+ requisitante, fonte);
            solicitante.Alignment = Element.ALIGN_CENTER;
            document.Add(solicitante);

            Paragraph setor = new Paragraph("Setor: " + pSetor, fonte);
            setor.Alignment = Element.ALIGN_CENTER;
            document.Add(setor);

            Paragraph section2 = new Paragraph();
            section2.Add(new Paragraph(" "));
            document.Add(section2);

            Paragraph hCell = new Paragraph("Materiais", fonteBranca);
            hCell.Alignment = Element.ALIGN_CENTER;
            Paragraph coluna1 = new Paragraph("Item", fonte);
            coluna1.Alignment = Element.ALIGN_CENTER;
            Paragraph coluna2 = new Paragraph("Quantidade", fonte);
            coluna2.Alignment = Element.ALIGN_CENTER;
            Paragraph coluna3 = new Paragraph("Operador", fonte);
            coluna3.Alignment = Element.ALIGN_CENTER;

            PdfPCell headerCell = new PdfPCell();
            headerCell.Colspan = 3;
            headerCell.BackgroundColor = BaseColor.BLUE;

            PdfPCell coll1 = new PdfPCell();
            coll1.BackgroundColor = BaseColor.GRAY;

            PdfPCell coll2 = new PdfPCell();
            coll2.BackgroundColor = BaseColor.GRAY;

            PdfPCell coll3 = new PdfPCell();
            coll3.BackgroundColor = BaseColor.GRAY;

            headerCell.AddElement(hCell);
            coll1.AddElement(coluna1);
            coll2.AddElement(coluna2);
            coll3.AddElement(coluna3);

            tabela.AddCell(headerCell);
            tabela.AddCell(coll1);
            tabela.AddCell(coll2);
            tabela.AddCell(coll3);
            
            foreach (var i in list)

            {
                
                Font font = FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 8);
                
                Paragraph paragrafo2 = new Paragraph(i.nome, font);
                Phrase material = new Phrase(paragrafo2);
                PdfPCell celula1 = new PdfPCell(material);
                celula1.HorizontalAlignment = Element.ALIGN_CENTER;
                celula1.VerticalAlignment = Element.ALIGN_CENTER;
                tabela.AddCell(celula1);

                Paragraph paragrafo3 = new Paragraph(i.quantidade, font);
                Phrase quanti = new Phrase(paragrafo3);
                PdfPCell celula2 = new PdfPCell(quanti);
                celula2.HorizontalAlignment = Element.ALIGN_CENTER;
                celula2.VerticalAlignment = Element.ALIGN_CENTER;
                tabela.AddCell(celula2);
                
                Paragraph paragrafo5 = new Paragraph(i.operador, font);
                Phrase op = new Phrase(paragrafo5);
                PdfPCell celula3 = new PdfPCell(op);
                celula3.HorizontalAlignment = Element.ALIGN_CENTER;
                celula3.VerticalAlignment = Element.ALIGN_CENTER;
                tabela.AddCell(celula3);

            }

            Paragraph section3 = new Paragraph();
            section3.Add(new Paragraph(" "));
            document.Add(section3);

            document.Add(tabela);
            Paragraph assinarutaData = new Paragraph("Assinatura: ________________________________________________________________ Data __/__/____");
            assinarutaData.Alignment = Element.ALIGN_BASELINE;
            document.Add(assinarutaData);
            document.Close();

            return true;
        }

    }
}
