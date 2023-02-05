using Microsoft.AspNetCore.Mvc;
using Ticket.API.Models;

namespace Ticket.API.Controllers;

public class TicketController : Controller
{
    // GET
    [Route("/")]
    public IActionResult Index()
    {
        var rows = new List<Row>()
        {
            new()
            {
                StartY = -10,
                Columns = new List<Column>()
                {
                    new() { StartX = 10, Text = "TEŞEKKÜRLER" }
                }
            },
            new()
            {
                StartY = -20,
                Columns = new List<Column>()
                {
                    new(){StartX = 10, Text = "GUNEYDOĞU TEKS. GIDA INS SAN. LTD.STI."}
                }
            },
            new()
            {
                StartY = -30,
                Columns = new List<Column>()
                {
                    new(){StartX = 15, Text = "ORNEKTEPE MAH.ETIBANK CAD.SARAY APT."}
                }
            },
            new()
            {
                StartY = -40,
                Columns = new List<Column>()
                {
                    new(){StartX = 30, Text = "N:43-1 BEYOĞLU/ISTANBUL"}
                }
            },
            new()
            {
                StartY = -50,
                Columns = new List<Column>()
                {
                    new(){StartX = 20, Text = "GÜNEŞLİ V.D. 4350078928 V. NO."}
                }
            },
            new()
            {
                StartY = -70,
                Columns = new List<Column>()
                {
                    new(){StartX = 15, Text = "TARIH : 26.08.2020"}
                }
            },
            new()
            {
                StartY = -80,
                Columns = new List<Column>()
                {
                    new(){StartX = 15, Text = "SAAT : 15:27"}
                }
            },
            new()
            {
                StartY = -90,
                Columns = new List<Column>()
                {
                    new(){StartX = 20, Text = "FİŞ NO : 0082"}
                }
            },
            new()
            {
                
                StartY = -110,
                Columns = new List<Column>()
                {
                    new(){StartX = 20, Text = "54491250"}
                }
            },
            new()
            {
                StartY = -120,
                Columns = new List<Column>()
                {
                    new(){StartX = 10, Text = "2 ADx 2,75"}
                }
            },
            new()
            {
                StartY = -130,
                Columns = new List<Column>()
                {
                    new(){StartX = 10, Text = "CC.COCA COLA CAM 200"},
                    new(){StartX = 100, Text = "%08"},
                    new(){StartX = 180, Text = "*5,50"},
                }
            },
            new()
            {
                StartY = -140,
                Columns = new List<Column>()
                {
                    new(){StartX = 20, Text = "2701084"}
                }
            },
            new()
            {
                StartY = -150,
                Columns = new List<Column>()
                {
                    new(){StartX = 10, Text = "1,566 KGx 1,99"}
                }
            },
            new()
            {
                StartY = -160,
                Columns = new List<Column>()
                {
                    new(){StartX = 10, Text = "MANAV DOMATES PETEME"},
                    new(){StartX = 180, Text = "*3,32"},
                }
            },
            new()
            {
                StartY = -170,
                Columns = new List<Column>()
                {
                    new(){StartX = 20, Text = "2701076"}
                }
            },
            new()
            {
                StartY = -180,
                Columns = new List<Column>()
                {
                    new(){StartX = 10, Text = "0,358 KGx 4,99"}
                }
            },
            new()
            {
                StartY = -190,
                Columns = new List<Column>()
                {
                    new(){StartX = 10, Text = "MANAV BIBER CARLISTO"},
                    new(){StartX = 100, Text = "%08"},
                    new(){StartX = 180, Text = "*1,79"},
                }
            },
            new()
            {
                StartY = -200,
                Columns = new List<Column>()
                {
                    new(){StartX = 20, Text = "4"}
                }
            },
            new()
            {
                StartY = -210,
                Columns = new List<Column>()
                {
                    new(){StartX = 10, Text = "EKMEK CIFTLI"},
                    new(){StartX = 100, Text = "%01"},
                    new(){StartX = 180, Text = "*1,25"},
                }
            },
            new()
            {
                StartY = -230,
               BeforeSeperator = true,
               Columns = new List<Column>()
               {
                   new(){StartX = 20, Text = "TOPKDV"},
                   new(){StartX = 180, Text = "*0,80"},
               }
            },
            new()
            {
                StartY = -240,
                Columns = new List<Column>()
                {
                    new(){StartX = 20, Text = "TOPLAM"},
                    new(){StartX = 180, Text = "*11,86"},
                }
            },
            new()
            {
                StartY = -260,
                BeforeSeperator = true,
                Columns = new List<Column>()
                {
                    new(){StartX = 30, Text = "NAKIT"},
                    new(){StartX = 150, Text = "*20,00"},
                }
            },
            new()
            {
                StartY = -280,
                Columns = new List<Column>()
                {
                    new(){StartX = 30, Text = "KDV"},
                    new(){StartX = 90, Text = "KDV TUTARI"},
                    new(){StartX = 150, Text = "KDV'LI TOPLAM"},
                }
            },
            new()
            {
                StartY = -290,
                Columns = new List<Column>()
                {
                    new(){StartX = 30, Text = "%01"},
                    new(){StartX = 90, Text = "*0,01"},
                    new(){StartX = 150, Text = "*1,25"},
                }
            },
            new()
            {
                StartY = -300,
                Columns = new List<Column>()
                {
                    new(){StartX = 30, Text = "*08"},
                    new(){StartX = 90, Text = "*0,79"},
                    new(){StartX = 150, Text = "*10,61"},
                }
            },
            new()
            {
                StartY = -320,
                Columns = new List<Column>()
                {
                    new(){StartX = 30, Text = "KASIYER : SUPERVISOR"},
                }
            },
            new()
            {
                StartY = -340,
                Columns = new List<Column>()
                {
                    new(){StartX = 30, Text = "00 0001/020/000084/1//82/"},
                }
            },
            new()
            {
                StartY = -350,
                Columns = new List<Column>()
                {
                    new(){StartX = 30, Text = "PARA ÜSTÜ"},
                    new(){StartX = 180, Text = "*8,14"},
                }
            },
            new()
            {
                StartY = -370,
                Columns = new List<Column>()
                {
                    new(){StartX = 30, Text = "KASİYER : 1"},
                }
            },
            new()
            {
                StartY = -380,
                Columns = new List<Column>()
                {
                    new(){StartX = 30, Text = "2 NO:1330"},
                    new(){StartX = 180, Text = "EKÜ NO:0001"},
                }
            },
            new()
            {
                StartY = -390,
                Columns = new List<Column>()
                {
                    new(){StartX = 70, Text = "MF YAB 15017876"}
                }
            }
        };
        return Json(rows);
    }
}