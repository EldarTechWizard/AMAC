using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbManagmentAMAC.Models;
using DevExpress.Data.Filtering.Helpers;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using SkiaSharp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AMAC.Views.FormatManagement.FormatNewAdoptionView
{
    public class PdfGenerator
    {
        private string lastError = "";
        private Animal animal = new Animal();
        private Adopter adopter = new Adopter();
        private PdfFormat pdfFormat = new PdfFormat();
        public string LastError { get => lastError; }
        public PdfGenerator(Animal _animal, Adopter _adopter, PdfFormat _pdfFormat)
        {
            this.animal = _animal;
            this.adopter = _adopter;
            this.pdfFormat = _pdfFormat;
        }

        

        public bool GeneratePdf(string path)
        {
            try
            {
                
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                              
                var document = Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(1, Unit.Centimetre);
                        page.PageColor(Colors.White);
                        page.DefaultTextStyle(x => x.FontSize(20));

                        var bmp = new Bitmap(AMAC.Properties.Resources.AMAC);
                        byte[] image = ToByteArray(bmp,System.Drawing.Imaging.ImageFormat.Bmp);

                        page.Header()
                            .Row(row =>
                            {
                                row.ConstantItem(60)
                                .Height(2, Unit.Centimetre)
                                .Image(image)
                                .FitHeight()
                                .WithCompressionQuality(ImageCompressionQuality.Medium);

                                row.RelativeItem(2)
                                .PaddingLeft(2, Unit.Centimetre)
                                .AlignMiddle()
                                .Text("CERTIFICADO DE ADOPCION")
                                .FontSize(24)
                                .FontColor("#2F3872")
                                .Bold()
                                ;
                            });


                        page.Content()
                            .Column(column =>
                            {
                                column.Item().Element(Title1);
                                column.Item().Element(FieldsAnimal);
                                column.Item().Element(Tittle2);
                                column.Item().Element(FieldsAdopter);
                                column.Item().Element(ContainerGeneralInfo);
                                column.Item().Element(ContainerWarningInfo);
                                column.Item().Element(FooterContainer);
                            });


                    });
                });

                document.GeneratePdf(path);

                return true;
            }catch(Exception ex)
            {
                lastError = ex.Message;
                return false;
            }
        }

        public static byte[] ToByteArray(System.Drawing.Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                return ms.ToArray();
            }
        }
        void Title1(QuestPDF.Infrastructure.IContainer container)
        {
            container
                .Padding(10)
                .ShrinkVertical()
                .Layers(layers =>
                {
                    DrawTextHeader(layers, "DATOS DE LAS MASCOTA QUE SE ESTA ADOPTANDO");
                });

        }

        void DrawTextHeader(LayersDescriptor layers, string text)
        {
            layers.Layer().Canvas((canvas, size) =>
            {
                DrawRoundedRectangle("#2F3872", false, canvas, size);
            });

            layers
                .PrimaryLayer()
                .AlignMiddle()
                .AlignCenter()
                .PaddingVertical(1)
                .Text(text)
                .FontSize(8).FontColor("#ffffff").Bold();
        }
        void DrawRoundedRectangle(string color, bool isStroke, SKCanvas canvas, QuestPDF.Infrastructure.Size size)
        {
            var paint = new SKPaint
            {
                Color = SKColor.Parse(color),
                IsStroke = isStroke,
                StrokeWidth = 1,
                IsAntialias = true
            };
            canvas.DrawRoundRect(0, 0, size.Width, size.Height, 5, 5, paint);
        }

        void FieldsAnimal(QuestPDF.Infrastructure.IContainer container)
        {
            container
                .PaddingHorizontal(10)
                .ShrinkVertical()
                .Layers(layers =>
                {
                    layers.Layer().Canvas((canvas, size) =>
                    {
                        DrawRoundedRectangle("#2F3872", true, canvas, size);
                    });

                    layers
                        .PrimaryLayer()
                        .Padding(5)
                        .Column(col =>
                        {


                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text(text =>
                                {
                                    text.Span($"NOMBRE: ").FontSize(8).FontColor("#2F3872");
                                    text.Span($"{animal.Name}").FontSize(8).FontColor("#2F3872").Bold();
                                });
                                row.RelativeItem().Text(text =>
                                {
                                    text.Span($"Categoria: ").FontSize(8).FontColor("#2F3872");
                                    text.Span($"{animal.AnimalType}").FontSize(8).FontColor("#2F3872").Bold();
                                });
                                row.RelativeItem().Text(text =>
                                {
                                    text.Span($"RAZA: ").FontSize(8).FontColor("#2F3872");
                                    text.Span($"{animal.AnimalBreed}").FontSize(8).FontColor("#2F3872").Bold();
                                });
                            });

                            string animalAge = (animal.Age == -1)? "" : animal.Age.ToString();

                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text(text =>
                                {
                                    text.Span($"EDAD: ").FontSize(8).FontColor("#2F3872");
                                    text.Span($"{animal.Age}").FontSize(8).FontColor("#2F3872").Bold();
                                });
                                row.RelativeItem().Text(text =>
                                {
                                    text.Span($"SEXO: ").FontSize(8).FontColor("#2F3872");
                                    text.Span($"{animal.Sex}").FontSize(8).FontColor("#2F3872").Bold();
                                });

                                string s = (animal.Sterilized) ? "SI" : "NO";

                                row.RelativeItem().Text(text =>
                                {
                                    text.Span($"ESTERILIZADO: ").FontSize(8).FontColor("#2F3872");
                                    text.Span($"{s}").FontSize(8).FontColor("#2F3872").Bold();
                                });
                            });

                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text(text =>
                                {
                                    text.Span($"INFORMACION ADICIONAL: ").FontSize(8).FontColor("#2F3872");
                                    text.Span($"{animal.AdditionalInformation}").FontSize(8).FontColor("#2F3872").Bold();
                                });
                            });

                        });
                });
        }

        void Tittle2(QuestPDF.Infrastructure.IContainer container)
        {
            container
                .Padding(10)
                .ShrinkVertical()
                .Layers(layers =>
                {
                    DrawTextHeader(layers, "DATOS GENERALES DEL ADOPTANTE");
                });
        }

        void FieldsAdopter(QuestPDF.Infrastructure.IContainer container)
        {
            container
                .PaddingHorizontal(10)
                .ShrinkVertical()
                .Layers(layers =>
                {
                    layers.Layer().Canvas((canvas, size) =>
                    {
                        DrawRoundedRectangle("#2F3872", true, canvas, size);
                    });

                    layers
                        .PrimaryLayer()
                        .Padding(5)
                        .Column(col =>
                        {


                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text(text => 
                                {
                                    text.Span($"NOMBRE: ").FontSize(8).FontColor("#2F3872");
                                    text.Span($"{adopter.Name}").FontSize(8).FontColor("#2F3872").Bold();
                                });
                            });

                            string adopterAge = (adopter.Age == -1) ? "" : adopter.Age.ToString();

                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text(text =>
                                {
                                    text.Span($"EDAD: ").FontSize(8).FontColor("#2F3872");
                                    text.Span($"{adopter.Age}").FontSize(8).FontColor("#2F3872").Bold();
                                });
                            });

                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text(text =>
                                {
                                    text.Span($"DOMICILIO: ").FontSize(8).FontColor("#2F3872");
                                    text.Span($"{adopter.Address}").FontSize(8).FontColor("#2F3872").Bold();
                                });
                            });

                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text(text =>
                                {
                                    text.Span($"TELEFONO: ").FontSize(8).FontColor("#2F3872");
                                    text.Span($"{adopter.Number}").FontSize(8).FontColor("#2F3872").Bold();
                                });
                            });

                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text(text =>
                                {
                                    text.Span($"EMAIL: ").FontSize(8).FontColor("#2F3872");
                                    text.Span($"{adopter.Email}").FontSize(8).FontColor("#2F3872").Bold();
                                });
                            });

                        });
                });
        }

        void ContainerGeneralInfo(QuestPDF.Infrastructure.IContainer container)
        {
            container
                .PaddingHorizontal(10)
                .PaddingTop(10)
                .ShrinkVertical()
                .Layers(layers =>
                {
                    layers.Layer().Canvas((canvas, size) =>
                    {
                        DrawRoundedRectangle("#2F3872", true, canvas, size);
                    });

                    layers
                        .PrimaryLayer()
                        .Padding(10)

                        .Column(col =>
                        {
                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text("COMPROMISO").FontSize(8).FontColor("#2F3872").Bold();
                            });

                            col.Item().Row(row =>
                            {
                                row.RelativeItem()
                                    .PaddingTop(1)
                                    .Text($"Me comprometo a encargarme de esta mascota: cuidarlo, quererlo y atender todas sus necesidades tanto de alimentacion, salud y convivencia. En caso de no poder cuidarlo, lo notificare a AMAC para tomar las medidas pertinentes. NO LO ENTREGARE A OTRA PERSONA SIN PREVIA NOTIFICACION NI AUTORIZACION.")
                                    .FontSize(8)
                                    .FontColor("#2F3872");
                            });

                            col.Item().Row(row =>
                            {
                                row.RelativeItem()
                                .PaddingTop(10)
                                    .Text("CONDICIONES")
                                    .FontSize(8)
                                    .FontColor("#2F3872")
                                    .Bold();
                            });

                            col.Item().Row(row =>
                            {
                                row.RelativeItem()
                                    .PaddingTop(1)
                                    .Text(text =>
                                    {
                                        text.Span($"-El (la) adoptante se compromete a dar al animal buena alimentacion; convivir con el animalito, atenciones que requiera; darle un lugar adecuado: seguro, protegido del frio, lluvia o sol, etc, donde vivir.{Environment.NewLine}-La mascota ").FontSize(8).FontColor("#2F3872");
                                        text.Span($"{animal.Name}").FontSize(8).Bold().FontColor("#2F3872");
                                        text.Span($" recibira siempre la atencion medica necesaria; y estos gastos son a partir de hoy, a cargo del adoptante").FontSize(8).FontColor("#2F3872");
                                    });
       
                            });

                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text($"-La mascota llevara siempre en su cuello, un collar con identificacion y numero telefonico de su hogar.{Environment.NewLine}-Si se adopta un cachorro, se compromete a esterilizaro a la edad de seis meses")
                                .FontSize(8)
                                .FontColor("#2F3872");
                            });

                            col.Item().Row(row =>
                            {
                                row.RelativeItem().Text($"-Informanos de cambios de domicilio y numero telefonico {Environment.NewLine}-AMAC se reserva el derecho de llamar o visitar el hogar del animalito adoptado.")
                                .FontSize(8)
                                .FontColor("#2F3872");
                            });

                        });
                });
        }

        void ContainerWarningInfo(QuestPDF.Infrastructure.IContainer container)
        {
            container
                .Padding(10)
                .ShrinkVertical()
                .Layers(layers =>
                {
                    DrawTextHeaderLeft(layers, "*Cualquiera de estas condiciones que NO fuese cumplida, sera motivo para que el animal sea recogido por voluntari@s de AMAC Gsv AC; se haga publico el incumplimiento de algun acuerdo; o se levante denuncia de acuerdo a la Ley de Proteccion para los animales del Estado de Sinaloa, en caso de ser necesario.");
                });
        }

        void DrawTextHeaderLeft(LayersDescriptor layers, string text)
        {
            layers.Layer().Canvas((canvas, size) =>
            {
                DrawRoundedRectangle("#2F3872", false, canvas, size);
            });

            layers
                .PrimaryLayer()
                .AlignMiddle()
                .AlignLeft()
                .PaddingVertical(5)
                .PaddingHorizontal(10)
                .Text(text)
                .FontSize(8).FontColor("#ffffff").Bold();
        }

        void FooterContainer(QuestPDF.Infrastructure.IContainer container)
        {
            container
               .PaddingHorizontal(10)
               .PaddingTop(10)

               .Layers(layers =>
               {
                   layers.Layer().Canvas((canvas, size) =>
                   {
                       DrawRoundedRectangle("#2F3872", true, canvas, size);
                   });

                   layers
                       .PrimaryLayer()
                       .Padding(10)

                       .Column(col =>
                       {
                           col.Item()
                           .PaddingTop(5)
                           .Row(row =>
                           {
                               row.RelativeItem().Text("DONATIVO:____________________________________________________________________________________________________________").FontSize(8).FontColor("#2F3872").Bold();
                           });

                           col.Item()
                           .PaddingTop(15)
                           .Row(row =>
                           {
                               row.RelativeItem()
                                   .PaddingTop(1)
                                   .Text(text =>
                                   {
                                       text.Span("Guasave, Sin, a ").FontSize(8).FontColor("#2F3872");
                                       text.Span($"{pdfFormat.AdoptionDate.Day}").FontSize(8).FontColor("#2F3872").Bold();
                                       text.Span($" de ").FontSize(8).FontColor("#2F3872");
                                       text.Span($"{pdfFormat.AdoptionDate.ToString("MMMM")}").FontSize(8).FontColor("#2F3872").Bold();
                                       text.Span($" de ").FontSize(8).FontColor("#2F3872");
                                       text.Span($"{pdfFormat.AdoptionDate.Year}").FontSize(8).FontColor("#2F3872").Bold();
                                   });
                                   
                                   
                           });

                           col.Item()
                           .PaddingTop(15)
                           .Row(row =>
                           {
                               row.RelativeItem()
                               .AlignCenter()
                               .Text("Declaro aceptar las condiciones.").FontSize(8).FontColor("#2F3872").Bold();

                               row.RelativeItem()
                               .AlignCenter()
                               .Text("VOLUNTARI@ A CARGO DE LA ADOPCION. (Nombre)").FontSize(8).FontColor("#2F3872").Bold();
                           });

                           col.Item()
                           .PaddingTop(30)
                           .Row(row =>
                           {
                               row.RelativeItem()
                               .AlignCenter()
                               .Text("__________________________________________").FontSize(8).FontColor("#2F3872").Bold();

                               row.RelativeItem()
                               .AlignCenter()
                               .Text($"{pdfFormat.Volunter}").FontSize(8).FontColor("#2F3872").Bold();
                           });

                           col.Item()
                           .PaddingTop(2)
                           .Row(row =>
                           {
                               row.RelativeItem()
                               .AlignCenter()
                               .Text("Firma del adoptante").FontSize(8).FontColor("#2F3872").Bold();

                               row.RelativeItem()
                               .AlignCenter()
                               .Text("                                          ").FontSize(8).FontColor("#2F3872").Bold();
                           });

                       });
               });
        }

    }
}
