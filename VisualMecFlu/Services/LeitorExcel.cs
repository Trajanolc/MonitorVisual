﻿using GemBox.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualMecFlu.Models;

namespace VisualMecFlu.Services
{
    internal static class LeitorExcel
    {

        private static List<string> _titulosPadrao = new List<string>() { "LABEL", "ID", "Entrada 1", "Entrada 2"};
        public static List<CargaDados> lerArquivo()
        {
            var lista = new List<CargaDados>();

            using (OpenFileDialog dialog = new OpenFileDialog() { Filter = "Arquivos Excel|*.xls;*.xlsx;*.xlsm", ValidateNames = true, Title = "Selecione um arquivo Excel" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream fileStream = File.OpenRead(dialog.FileName);

                    SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

                    var Workbook = ExcelFile.Load(fileStream);

                    var Sheet = Workbook.Worksheets.FirstOrDefault();

                    if (Sheet == null)
                    {
                        throw new Exception("Arquivo inválido");
                    }

                    foreach (var row in Sheet.Rows.Skip(1))
                    {
                        var celulas_validas = row.AllocatedCells.Take(4).ToList();

                        if (celulas_validas.Count != 4 || celulas_validas.Any(e => string.IsNullOrEmpty(e.StringValue)))
                        {
                            break;
                        }
                        var id = celulas_validas[1].IntValue;
                        var p1 = celulas_validas[2].IntValue;
                        var p2 = celulas_validas[3].IntValue;

                        lista.Add(new CargaDados()
                        {
                            Id = id,
                            P1 = p1,
                            P2 = p2
                        });
                    }

                    if (lista.Count == 0)
                    {
                        throw new Exception("Planilha sem dados");
                    }

                    return lista;
                }
                else {
                    throw new Exception("Arquivo não selecionado");
                }
            }

            throw new Exception("Erro ao processar planilha");
        }
    }
}
