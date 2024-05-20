using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace ProgramNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menuItems = { "AGENDA ELECTRÓNICA \n", "UTILITARIOS \n", "SALIR" };
            int selectedItem = 0;
            //sub menu - primera opcion 
            string[] menuItems2 = { "CONTACTOS\n", "EVENTOS\n", "BLOC DE NOTAS\n", "SALIR AL MENÚ PRINCIPAL" };
            int selectedItem2 = 0;

            //Conversor
            string[] Munu_conversor = {"Conversor de temperaturas \n", "conversor de monedas"};
            int opcion_conversor = 0;

            //conversor de temperaturas
            string[] menu_temperaturas = {"Grados Fahrenheit \n", "Grados Celsius \n", "Grados Kelvin"};
            int selected_temperatras = 0;


            string[] submenu_2da_opciono = {"Conversor de Unidades \n", "Calculadora \n", "Excel Office 365 \n", "Power Point Office 365 \n ", "Word Office 365 \n", "¿Preguntas por resolver? \n"};
            int Sub_menu_2da_opcion = 0;

            //sub menu 2 - primera opcion
            string[] menu_eventos = {"Ver Eventos\n", "Agregar Evento \n", "Editar Evento \n", "Eliminar Evento"};
            int selectdEvento = 0;
            //opcio-recordatrio

            Console.CursorVisible = false;
            ConsoleKeyInfo keyInfo;

            //Contacto
            string[] menu_contactos = {"Ver contactos \n", "Agregar contacto nuevo \n", "Editar contacto \n", "Eliminar contacto"};
            int selectedContacto = 0;
            List<string> Nombres = new List<string>();
            List<string> Apellidos = new List<string>();
            List<string> Empresa = new List<string>();
            List<string> Archivar_como = new List<string>();
            List<string> Telefono = new List<string>();
            List<string> Dirección = new List<string>();
            List<string> Email = new List<string>();
            List<string> Etiqueta = new List<string>();

            //Evento
            List<string> Tipo_de_evento = new List<string>();
            List<string> Recordatorio_todo_el_dia = new List<string>();
            List<string> Agregar_personas = new List<string>();
            List<string> Agregar_una_videoconferencia = new List<string>();
            List<string> Agregar_Ubicación = new List<string>();
            List<string> Agregar_Descripcion = new List<string>();
            List<string> Agregar_archivo_adjunto = new List<string>();

            //Bloc de notas
            List<string> asunto = new List<string>();
            List<string> bloc_de_notas = new List<string>();
            string [] menu_bloc_de_notas = {"Ver Notas Escritas \n", "Agregar Bloc de notas Nuevo \n"};
            //{"Ver Notas Escritas \n", "Agregar Bloc de notas Nuevo \n", "Editar Bloc de Notas \n", "Eliminar Bloc de Notas"};
            int selected_bloc_de_notas = 0;

            //Menu calculadora
            string[] menu_calculadora = {"Sumar \n", "Restar \n ", "Dividir \n ", "Multiplicar \n"};
            int respuesta_calculadora = 0;

            Console.Clear();
            ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Magenta, ConsoleColor.Cyan };

            int currentColor = 0;

            while (true)
            {

                Console.ForegroundColor = colors[currentColor];

                Console.Write("\r                                                                  Pulsa ENTER para iniciar");

                currentColor++;
                if (currentColor >= colors.Length)
                {
                 currentColor = 0;
                }

                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                  break;
                }
                System.Threading.Thread.Sleep(500);

            }

            Console.ResetColor();
            Console.Clear();
 
            while (true)
            {
                menuprincipal();
                
                // ConsoleKeyInfo keyInfo = Console.ReadKey();

                do
                {
                    keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.UpArrow)
                    {
                        selectedItem--;

                        if (selectedItem < 0)
                        {
                            selectedItem = menuItems.Length - 1;
                        }

                    }
                    else if (keyInfo.Key == ConsoleKey.DownArrow)
                    {
                        selectedItem++;

                        if (selectedItem >= menuItems.Length)
                        {
                            selectedItem = 0;
                        }

                    }
                    menuprincipal();
                } while (keyInfo.Key != ConsoleKey.Enter);


                switch (selectedItem )
                {
                    case 0: 
                    
                          Sub_menu_1era_Opcion();
                              
                            do
                            {
                                keyInfo = Console.ReadKey();
                                if (keyInfo.Key == ConsoleKey.UpArrow)
                                {
                                  selectedItem2--;

                                  if (selectedItem2 < 0)
                                  {
                                    selectedItem2 = menuItems2.Length - 1;
                                  }
                                }
                                else if (keyInfo.Key == ConsoleKey.DownArrow)
                                {
                                  selectedItem2++;

                                  if (selectedItem2 >= menuItems2.Length)
                                  {
                                   selectedItem2 = 0;
                                  }
                                }

                                Sub_menu_1era_Opcion();
                            } while (keyInfo.Key != ConsoleKey.Enter);

                            switch (selectedItem2)
                            {
                              case 0: 
                              contactos();
                              do
                             {
                                 keyInfo = Console.ReadKey();
                                  if (keyInfo.Key == ConsoleKey.UpArrow)
                                  {
                                    selectedContacto--;

                                    if (selectedContacto < 0)
                                   {
                                    selectedContacto = menu_contactos.Length - 1;
                                   }
                                  }
                                  else if (keyInfo.Key == ConsoleKey.DownArrow)
                                  {
                                    selectedContacto++;
 
                                    if (selectedContacto >= menu_contactos.Length)
                                    {
                                     selectedContacto = 0;
                                    }
                                  }

                                contactos();
                             } while (keyInfo.Key != ConsoleKey.Enter);

                              switch (selectedContacto)
                              {
                                case 0: 
                                Vercontactos(Nombres,Apellidos,Empresa,Archivar_como,Telefono,Dirección,Email,Etiqueta);

                                Console.ReadKey();
                                break;

                                case 1:
                                Agregarcontactos(Nombres,Apellidos,Empresa,Archivar_como,Telefono,Dirección,Email,Etiqueta);
                                break;

                                case 2:
                                editar(Nombres,Apellidos,Empresa,Archivar_como,Telefono,Dirección,Email,Etiqueta);
                                break;

                                case 3:
                                eliminarcontactos(Nombres,Apellidos,Empresa,Archivar_como,Telefono,Dirección,Email,Etiqueta);
                                break;
                              }
                              break;

                              case 1: 
                              eventos();

                              do
                              {
                                keyInfo = Console.ReadKey();
                                if (keyInfo.Key == ConsoleKey.UpArrow)
                                {
                                  selectdEvento--;
                                  if (selectdEvento < 0)
                                  {
                                    selectdEvento = menu_eventos.Length - 1;
                                  }
                                }
                                else if (keyInfo.Key == ConsoleKey.DownArrow)
                                {
                                  selectdEvento++;
                                  if (selectdEvento >= menu_eventos.Length)
                                  {
                                    selectdEvento = 0;
                                  }
                                }
                                eventos();
                              } while (keyInfo.Key != ConsoleKey.Enter);

                              switch (selectdEvento)
                              {
                                case 0: ver_eventos(Tipo_de_evento,Recordatorio_todo_el_dia,Agregar_personas,Agregar_una_videoconferencia,Agregar_Ubicación,Agregar_Descripcion,Agregar_archivo_adjunto);
                                break;

                                case 1: agregareventos(Tipo_de_evento,Recordatorio_todo_el_dia,Agregar_personas,Agregar_una_videoconferencia,Agregar_Ubicación,Agregar_Descripcion,Agregar_archivo_adjunto);
                                break;

                                case 2:editar_evento(Tipo_de_evento,Recordatorio_todo_el_dia,Agregar_personas,Agregar_una_videoconferencia,Agregar_Ubicación,Agregar_Descripcion,Agregar_archivo_adjunto);
                                break;

                                case 3:Eliminar_eventos(Tipo_de_evento,Recordatorio_todo_el_dia,Agregar_personas,Agregar_una_videoconferencia,Agregar_Ubicación,Agregar_Descripcion,Agregar_archivo_adjunto);
                                break;
                              }
                              break;

                              case 2:
                              Bloc_de_notas_menu();

                              do
                              {
                                keyInfo = Console.ReadKey();
                                if (keyInfo.Key == ConsoleKey.UpArrow)
                                {
                                  selected_bloc_de_notas--;
                                  if (selected_bloc_de_notas < 0)
                                  {
                                    selected_bloc_de_notas= menu_bloc_de_notas.Length - 1;
                                  }
                                }
                                else if (keyInfo.Key == ConsoleKey.DownArrow)
                                {
                                  selected_bloc_de_notas++;
                                  if (selected_bloc_de_notas >= menu_bloc_de_notas.Length)
                                  {
                                    selected_bloc_de_notas = 0;
                                  }
                                }
                                Bloc_de_notas_menu();
                              } while (keyInfo.Key != ConsoleKey.Enter);

                              switch (selected_bloc_de_notas)
                              {
                                case 0:
                                ver_bloc_de_notas(asunto,bloc_de_notas);
                                break;

                                case 1:
                                Agregar_bloc_de_notas(asunto,bloc_de_notas);
                                break;
                                
                              }
                              break;
                            }
                        break;

                    case 1:
                    submenu_2da_();

                    do
                    {
                      keyInfo = Console.ReadKey();
                      if (keyInfo.Key == ConsoleKey.UpArrow)
                      {
                        Sub_menu_2da_opcion--;

                        if (Sub_menu_2da_opcion < 0)
                        {
                          Sub_menu_2da_opcion = submenu_2da_opciono.Length - 1;
                        }
                      }
                      else if (keyInfo.Key == ConsoleKey.DownArrow)
                      {
                        Sub_menu_2da_opcion++;

                        if (Sub_menu_2da_opcion >= submenu_2da_opciono.Length)
                        {
                          Sub_menu_2da_opcion = 0;
                        }
                      }
                      submenu_2da_();
                    } while (keyInfo.Key != ConsoleKey.Enter);

                    switch (Sub_menu_2da_opcion)
                    {
                      case 0:
                      menu_conversor_();

                      do
                      {
                        keyInfo = Console.ReadKey();
                        if (keyInfo.Key == ConsoleKey.UpArrow)
                        {
                          opcion_conversor--;

                          if (opcion_conversor < 0)
                          {
                            opcion_conversor = Munu_conversor.Length - 1;
                          }
                        }
                        else if (keyInfo.Key == ConsoleKey.DownArrow)
                          {
                            opcion_conversor++;
                            if (opcion_conversor >= Munu_conversor.Length)
                            {
                              opcion_conversor = 0;
                            }
                          }
                        menu_conversor_();
                      } while (keyInfo.Key != ConsoleKey.Enter);

                      switch (opcion_conversor)
                      {
                        case 0:
                        menu_temperaturas_();
                        do
                        {
                          keyInfo = Console.ReadKey();
                          if (keyInfo.Key == ConsoleKey.UpArrow)
                          {
                            selected_temperatras--;
                            if (selected_temperatras < 0)
                            {
                              selected_temperatras = menu_temperaturas.Length -1;
                            }
                          }
                          else if (keyInfo.Key == ConsoleKey.DownArrow)
                            {
                              selected_temperatras++;
                              if (selected_temperatras >= menu_temperaturas.Length)
                              {
                                selected_temperatras = 0;
                              }
                            }
                          menu_temperaturas_();
                        } while (keyInfo.Key != ConsoleKey.Enter);

                        switch (selected_temperatras)
                        {
                          case 0:
                          Fahrenheit_();
                          break;
                          
                          case 1:
                          celsisus_();
                          break;

                          case 2:
                          kelvin();
                          break;
                        }
                        break;
                      }
                      break;

                      case 1:
                      calculadora();
                      do
                        {
                          keyInfo = Console.ReadKey();
                          if (keyInfo.Key == ConsoleKey.UpArrow)
                          {
                            respuesta_calculadora--;
                            if (respuesta_calculadora< 0)
                            {
                              respuesta_calculadora= menu_calculadora.Length -1;
                            }
                          }
                          else if (keyInfo.Key == ConsoleKey.DownArrow)
                            {
                              respuesta_calculadora++;
                              if (respuesta_calculadora >= menu_calculadora.Length)
                              {
                                respuesta_calculadora = 0;
                              }
                            }
                          calculadora();
                        } while (keyInfo.Key != ConsoleKey.Enter);
                        switch (respuesta_calculadora)
                        {
                          case 0:
                          suma();
                          break;

                          case 1:
                          resta();
                          break;

                          case 2:
                          Dividir();
                          break;

                          case 3:
                          Multiplicar();
                          break;
                        }

                      break;

                      case 2:
                      var psi2 = new System.Diagnostics.ProcessStartInfo();
                      psi2.UseShellExecute = true;
                      psi2.FileName = "https://itlaedudo-my.sharepoint.com/:x:/r/personal/20221996_itla_edu_do/_layouts/15/Doc.aspx?sourcedoc=%7B0D017D39-3E80-4AC5-8E5B-1DD2C41FB686%7D&file=Libro.xlsx&action=editnew&mobileredirect=true&wdNewAndOpenCt=1682183785952&ct=1682183786525&wdPreviousSession=1bbf4f91-b202-4533-ab6f-2e45a2486764&wdOrigin=OFFICECOM-WEB.START.NEW&login_hint=20221996%40itla.edu.do&cid=18710fcd-9804-4f22-ac06-02ec81e7b215&wdPreviousSessionSrc=HarmonyWeb";
                      System.Diagnostics.Process.Start(psi2);
                      break;

                      case 3:
                      var psi3 = new System.Diagnostics.ProcessStartInfo();
                      psi3.UseShellExecute = true;
                      psi3.FileName = "https://itlaedudo-my.sharepoint.com/personal/20221996_itla_edu_do/_layouts/15/doc.aspx?sourcedoc={03a742a3-7f3b-4860-b737-ed3192c58534}&action=edit";
                      System.Diagnostics.Process.Start(psi3);
                      break;

                      case 4:
                      var psi = new System.Diagnostics.ProcessStartInfo();
                      psi.UseShellExecute = true;
                      psi.FileName = "https://www.office.com/launch/word?auth=2";
                      System.Diagnostics.Process.Start(psi);
                      break;

                      case 5:
                      var psi5 = new System.Diagnostics.ProcessStartInfo();
                      psi5.UseShellExecute = true;
                      psi5.FileName = "https://chat.openai.com/";
                      System.Diagnostics.Process.Start(psi5);
                      break;
                    }
                    break;

                    case 2:  Console.Clear();
                    System.Console.WriteLine(@"
                                      ╔═╗╔═╗╦  ╦╔═╗╔╗╔╔╦╗╔═╗  ╔╦╗╔═╗╦    ╔═╗╦═╗╔═╗╔═╗╦═╗╔═╗╔╦╗╔═╗
                                      ╚═╗╠═╣║  ║║╣ ║║║ ║║║ ║   ║║║╣ ║    ╠═╝╠╦╝║ ║║ ╦╠╦╝╠═╣║║║╠═╣
                                      ╚═╝╩ ╩╩═╝╩╚═╝╝╚╝═╩╝╚═╝  ═╩╝╚═╝╩═╝  ╩  ╩╚═╚═╝╚═╝╩╚═╩ ╩╩ ╩╩ ╩");
                                      Thread.Sleep(2000);
                                      return;
                }

            }

            void calculadora()
            {
              Console.Clear();
              Console.ForegroundColor = ConsoleColor.Green;
              System.Console.WriteLine(@"
                                               ╔═╗┌─┐┬  ┌─┐┬ ┬┬  ┌─┐┌┬┐┌─┐┬─┐┌─┐
                                               ║  ├─┤│  │  │ ││  ├─┤ │││ │├┬┘├─┤
                                               ╚═╝┴ ┴┴─┘└─┘└─┘┴─┘┴ ┴─┴┘└─┘┴└─┴ ┴");
              System.Console.WriteLine("\n");

                for (int i = 0; i < menu_calculadora.Length; i++)
                {
                    if (i == respuesta_calculadora)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine((i + 1) + ". " + menu_calculadora[i]);
                    Console.ResetColor();
                }
            }
            
            void menuprincipal()
            { Console.Clear();
                Console.WriteLine(@"
                                                ╔═╗┌─┐┬  ┌─┐┌─┐┌─┐┬┌─┐┌┐┌┌─┐  ┬ ┬┌┐┌┌─┐  ┌─┐┌─┐┌─┐┬┌─┐┌┐┌
                                                ╚═╗├┤ │  ├┤ │  │  ││ ││││├┤   │ ││││├─┤  │ │├─┘│  ││ ││││
                                                ╚═╝└─┘┴─┘└─┘└─┘└─┘┴└─┘┘└┘└─┘  └─┘┘└┘┴ ┴  └─┘┴  └─┘┴└─┘┘└┘");
                System.Console.WriteLine("\n");

                for (int i = 0; i < menuItems.Length; i++)
                {
                    if (i == selectedItem)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine((i + 1) + ". " + menuItems[i]);
                    Console.ResetColor();
                }
            }

            void menu_temperaturas_()
            {
              Console.Clear();
              System.Console.WriteLine(@"
                                                ╔╦╗┌─┐┌┬┐┌─┐┌─┐┬─┐┌─┐┌┬┐┬ ┬┬─┐┌─┐┌─┐
                                                 ║ ├┤ │││├─┘├┤ ├┬┘├─┤ │ │ │├┬┘├─┤└─┐
                                                 ╩ └─┘┴ ┴┴  └─┘┴└─┴ ┴ ┴ └─┘┴└─┴ ┴└─┘");
              System.Console.WriteLine("\n");

              for (int i = 0; i < menu_temperaturas.Length; i++)
                {
                    if (i == selected_temperatras)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine((i + 1) + ". " + menu_temperaturas[i]);
                    Console.ResetColor();
                }
            }

            void suma()
           {
              Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < 156; i++)
           {
            Console.Write("-");
            Thread.Sleep(10);
           }
           System.Console.WriteLine(@"
                                                         ╔═╗┬ ┬┌┬┐┌─┐
                                                         ╚═╗│ ││││├─┤
                                                         ╚═╝└─┘┴ ┴┴ ┴");
            for (int i = 0; i < 156; i++)
           {
            Console.Write("-");
            Thread.Sleep(10);
           }

           System.Console.WriteLine("\n \n \n(A continuacion introduzca dos numeros para sumarlos)");
           System.Console.Write("\n \nIntroduzca el primer numero: ");
           int num1 = Convert.ToInt32(Console.ReadLine()!);
           System.Console.Write("Introduzca el segundo numero: ");
           int num2 = Convert.ToInt32(Console.ReadLine()!);
           int resultado = num1 + num2;
           for (int i = 0; i < 156; i++)
           {
            Console.Write("-");
            Thread.Sleep(10);
           }
           System.Console.WriteLine($"su resultado es: {resultado}");
           System.Console.WriteLine("\n \n \n \n");
           ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Magenta, ConsoleColor.Cyan };

            int currentColor = 0;
          
            while (true)
            {

                Console.ForegroundColor = colors[currentColor];

                Console.Write("\r                                                                  Pulse ENTER para salir ");

                currentColor++;
                if (currentColor >= colors.Length)
                {
                    currentColor = 0;
                }

                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    break;
                }
                System.Threading.Thread.Sleep(500);
            }
           }

            void resta()
            {
              Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < 156; i++)
           {
            Console.Write("-");
            Thread.Sleep(10);
           }
           System.Console.WriteLine(@"
                                                        ┬─┐┌─┐┌─┐┌┬┐┌─┐
                                                        ├┬┘├┤ └─┐ │ ├─┤
                                                        ┴└─└─┘└─┘ ┴ ┴ ┴");
            for (int i = 0; i < 156; i++)
           {
            Console.Write("-");
            Thread.Sleep(10);
           }
           System.Console.WriteLine("\n \n \n(A continuacion introduzca dos numeros para restarlos)");
           System.Console.Write("\n \nIntroduzca el primer numero: ");
           int num1 = Convert.ToInt32(Console.ReadLine()!);
           System.Console.Write("Introduzca el segundo numero: ");
           int num2 = Convert.ToInt32(Console.ReadLine()!);
           int resultado = num1 - num2;
           for (int i = 0; i < 156; i++)
           {
            Console.Write("-");
            Thread.Sleep(10);
           }
           System.Console.WriteLine($"su resultado es: {resultado}");
           System.Console.WriteLine("\n \n \n \n");
           ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Magenta, ConsoleColor.Cyan };

            int currentColor = 0;
          
            while (true)
            {

                Console.ForegroundColor = colors[currentColor];

                Console.Write("\r                                                                  Pulse ENTER para salir ");

                currentColor++;
                if (currentColor >= colors.Length)
                {
                    currentColor = 0;
                }

                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    break;
                }
                System.Threading.Thread.Sleep(500);
            }
          }

            void Dividir()
            {
              Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < 156; i++)
           {
            Console.Write("-");
            Thread.Sleep(10);
           }
           System.Console.WriteLine(@"
                                                          ╔╦╗╦╔═╗╦╦  ╦╦╔═╗╔╗╔
                                                           ║║║╚═╗║╚╗╔╝║║ ║║║║
                                                          ═╩╝╩╚═╝╩ ╚╝ ╩╚═╝╝╚╝");
            for (int i = 0; i < 156; i++)
           {
            Console.Write("-");
            Thread.Sleep(10);
           }
           System.Console.WriteLine("\n \n \n(A continuacion introduzca dos numeros para Dividirlos)");
           System.Console.Write("\n \nIntroduzca el primer numero: ");
           int num1 = Convert.ToInt32(Console.ReadLine()!);
           System.Console.Write("Introduzca el segundo numero: ");
           int num2 = Convert.ToInt32(Console.ReadLine()!);
           int resultado = num1 / num2;
           for (int i = 0; i < 156; i++)
           {
            Console.Write("-");
            Thread.Sleep(10);
           }
           System.Console.WriteLine($"su resultado es: {resultado}");
           System.Console.WriteLine("\n \n \n \n");
           ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Magenta, ConsoleColor.Cyan };

            int currentColor = 0;
          
            while (true)
            {

                Console.ForegroundColor = colors[currentColor];

                Console.Write("\r                                                                  Pulse ENTER para salir ");

                currentColor++;
                if (currentColor >= colors.Length)
                {
                    currentColor = 0;
                }
              
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    break;
                }
                System.Threading.Thread.Sleep(500);
            }
           }

            void Multiplicar()
            {
              Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < 156; i++)
           {
            Console.Write("-");
            Thread.Sleep(10);
           }
           System.Console.WriteLine(@"
                                                    ╔╦╗╦ ╦╦ ╔╦╗╦╔═╗╦  ╦╔═╗╔═╗╔═╗╦╔═╗╔╗╔
                                                    ║║║║ ║║  ║ ║╠═╝║  ║║  ╠═╣║  ║║ ║║║║
                                                    ╩ ╩╚═╝╩═╝╩ ╩╩  ╩═╝╩╚═╝╩ ╩╚═╝╩╚═╝╝╚╝");
            for (int i = 0; i < 156; i++)
           {
            Console.Write("-");
            Thread.Sleep(10);
           }
           System.Console.WriteLine("\n \n \n(A continuacion introduzca dos numeros para Multiplicarlos)");
           System.Console.Write("\n \nIntroduzca el primer numero: ");
           int num1 = Convert.ToInt32(Console.ReadLine()!);
           System.Console.Write("Introduzca el segundo numero: ");
           int num2 = Convert.ToInt32(Console.ReadLine()!);
           int resultado = num1 * num2;
           for (int i = 0; i < 156; i++)
           {
            Console.Write("-");
            Thread.Sleep(10);
           }
           System.Console.WriteLine($"su resultado es: {resultado}");
           System.Console.WriteLine("\n \n \n \n");
           ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Magenta, ConsoleColor.Cyan };

            int currentColor = 0;
          
            while (true)
            {

                Console.ForegroundColor = colors[currentColor];

                Console.Write("\r                                                                  Pulse ENTER para salir ");

                currentColor++;
                if (currentColor >= colors.Length)
                {
                    currentColor = 0;
                }
              
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    break;
                }
                System.Threading.Thread.Sleep(500);
            }
            }

            void Sub_menu_1era_Opcion()
            {
                Console.Clear();
                System.Console.WriteLine(@"
                                            ╔═╗╔═╗╔═╗╔╗╔╔╦╗╔═╗  ╔═╗╦  ╔═╗╔═╗╔╦╗╦═╗╔═╗╔╗╔╦╔═╗╔═╗
                                            ╠═╣║ ╦║╣ ║║║ ║║╠═╣  ║╣ ║  ║╣ ║   ║ ╠╦╝║ ║║║║║║  ╠═╣
                                            ╩ ╩╚═╝╚═╝╝╚╝═╩╝╩ ╩  ╚═╝╩═╝╚═╝╚═╝ ╩ ╩╚═╚═╝╝╚╝╩╚═╝╩ ╩ ");                       
                System.Console.WriteLine("Elija una opción: \n");

                for (int i = 0; i < menuItems2.Length; i++)
                {
                    if (i == selectedItem2)
                    {
                        Console.BackgroundColor= ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black; 
                    }
                        else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine((i + 1) + ". " + menuItems2[i]);
                    Console.ResetColor();
                }          
            }

            void menu_conversor_()
            { Console.Clear();
            System.Console.WriteLine(@"
                                             ╔═╗┌─┐┌┐┌┬  ┬┌─┐┬─┐┌─┐┌─┐┬─┐  ╔╦╗┌─┐  ╔╦╗┌─┐┌┬┐┌─┐┌─┐┬─┐┌─┐┌┬┐┬ ┬┬─┐┌─┐
                                             ║  │ ││││└┐┌┘├┤ ├┬┘└─┐│ │├┬┘   ║║├┤    ║ ├┤ │││├─┘├┤ ├┬┘├─┤ │ │ │├┬┘├─┤
                                             ╚═╝└─┘┘└┘ └┘ └─┘┴└─└─┘└─┘┴└─  ═╩╝└─┘   ╩ └─┘┴ ┴┴  └─┘┴└─┴ ┴ ┴ └─┘┴└─┴ ┴");
              System.Console.WriteLine("Elija una opción: \n");

              for (int i = 0; i < Munu_conversor.Length; i++)
                {
                    if (i == opcion_conversor)
                    {
                        Console.BackgroundColor= ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black; 
                    }
                     else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine((i + 1) + ". " + Munu_conversor[i]);
                    Console.ResetColor();
                }
            }

            void submenu_2da_()
            {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            
              System.Console.WriteLine(@"
                                                 ╦ ╦╔╦╗╦╦  ╦╔╦╗╔═╗╦═╗╦╔═╗╔═╗
                                                 ║ ║ ║ ║║  ║ ║ ╠═╣╠╦╝║║ ║╚═╗
                                                 ╚═╝ ╩ ╩╩═╝╩ ╩ ╩ ╩╩╚═╩╚═╝╚═╝");
             
             for (int i = 0; i < submenu_2da_opciono.Length; i++)
                {
                    if (i == Sub_menu_2da_opcion)
                    {
                        Console.BackgroundColor= ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black; 
                    }
                        else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine((i + 1) + ". " + submenu_2da_opciono[i]);
                    Console.ResetColor();
                }
            }

            void Fahrenheit_()
          {
              Console.Clear();
              Console.ForegroundColor = ConsoleColor.Red;
              System.Console.WriteLine(@"
                                                ╔═╗┬─┐┌─┐┌┬┐┌─┐┌─┐  ╔═╗┌─┐┬ ┬┬─┐┌─┐┌┐┌┬ ┬┌─┐┬┌┬┐
                                                ║ ╦├┬┘├─┤ │││ │└─┐  ╠╣ ├─┤├─┤├┬┘├┤ │││├─┤├┤ │ │ 
                                                ╚═╝┴└─┴ ┴─┴┘└─┘└─┘  ╚  ┴ ┴┴ ┴┴└─└─┘┘└┘┴ ┴└─┘┴ ┴ ");
              System.Console.WriteLine("\n \n \n(Introduzca un numero para convertirlo a grados Fahrenheit)");
              Console.Write("Por favor ingrese la temperatura en grados Celsius:");
              double celsius = Convert.ToDouble(Console.ReadLine());

             double fahrenheit = celsius * 9 / 5 + 32;

              System.Console.WriteLine($"\n \nEl numero ingresado convertido a Fahrenheit es: {fahrenheit}");

              System.Console.WriteLine("\n \n \n \n");
           ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Magenta, ConsoleColor.Cyan };

            int currentColor = 0;
          
            while (true)
            {

                Console.ForegroundColor = colors[currentColor];

                Console.Write("\r                                                                  Pulse ENTER para salir ");

                currentColor++;
                if (currentColor >= colors.Length)
                {
                    currentColor = 0;
                }

                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    break;
                }
                System.Threading.Thread.Sleep(500);
            }
          }

          void celsisus_()
          {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            System.Console.WriteLine(@"
                                               ╔═╗┬─┐┌─┐┌┬┐┌─┐┌─┐  ╔═╗┌─┐┬  ┌─┐┬┬ ┬┌─┐
                                               ║ ╦├┬┘├─┤ │││ │└─┐  ║  ├┤ │  └─┐││ │└─┐
                                               ╚═╝┴└─┴ ┴─┴┘└─┘└─┘  ╚═╝└─┘┴─┘└─┘┴└─┘└─┘");
           System.Console.WriteLine("\n \n \n(Introduzca un numero para convertirlo a grados Celsius)");
           Console.WriteLine("Por favor ingrese la temperatura en grados Celsius:");
           double celsius = Convert.ToDouble(Console.ReadLine());

           double fahrenheit = celsius * 9 / 5 + 32;
            System.Console.WriteLine($"\n \nEl numero ingresado convertido a Celsius es: {fahrenheit}");
            System.Console.WriteLine("\n \n \n \n");
           ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Magenta, ConsoleColor.Cyan };

            int currentColor = 0;
          
            while (true)
            {

                Console.ForegroundColor = colors[currentColor];

                Console.Write("\r                                                                  Pulse ENTER para salir ");

                currentColor++;
                if (currentColor >= colors.Length)
                {
                    currentColor = 0;
                }

                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    break;
                }
                System.Threading.Thread.Sleep(500);
            }
          }

          void kelvin()
          {
             Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine(@"
                                               ╔═╗┬─┐┌─┐┌┬┐┌─┐┌─┐  ╦╔═┌─┐┬ ┬  ┬┬┌┐┌
                                               ║ ╦├┬┘├─┤ │││ │└─┐  ╠╩╗├┤ │ └┐┌┘││││
                                               ╚═╝┴└─┴ ┴─┴┘└─┘└─┘  ╩ ╩└─┘┴─┘└┘ ┴┘└┘");
           System.Console.WriteLine("\n \n \n(Introduzca un numero para convertirlo a grados Kelvin)");
           double celsius;
           double kelvin;
        
           Console.Write("Ingrese una temperatura en Celsius: ");
           celsius = Convert.ToDouble(Console.ReadLine());

           kelvin = celsius + 273.15;

           System.Console.WriteLine($"\n \nEl numero ingresado convertido a Kelvin es: {kelvin}");
            System.Console.WriteLine("\n \n \n \n");
           ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Magenta, ConsoleColor.Cyan };

            int currentColor = 0;
          
            while (true)
            {

                Console.ForegroundColor = colors[currentColor];

                Console.Write("\r                                                                  Pulse ENTER para salir ");

                currentColor++;
                if (currentColor >= colors.Length)
                {
                    currentColor = 0;
                }

                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    break;
                }
                System.Threading.Thread.Sleep(500);
            }

          }

            void contactos()
            {
              Console.Clear();
              System.Console.WriteLine(@"
                                           ╔═╗╔═╗╔╗╔╔╦╗╔═╗╔═╗╔╦╗╔═╗╔═╗
                                           ║  ║ ║║║║ ║ ╠═╣║   ║ ║ ║╚═╗
                                           ╚═╝╚═╝╝╚╝ ╩ ╩ ╩╚═╝ ╩ ╚═╝╚═╝");

              System.Console.WriteLine("Elija una opción: \n");

              for (int i = 0; i < menu_contactos.Length; i++)
                {
                    if (i == selectedContacto)
                    {
                        Console.BackgroundColor= ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black; 
                    }
                        else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine((i + 1) + ". " + menu_contactos[i]);
                    Console.ResetColor();
                }


            }

            void Bloc_de_notas_menu()
            {
              Console.Clear();
              System.Console.WriteLine(@"
                                                ╔╗ ┬  ┌─┐┌─┐  ┌┬┐┌─┐  ╔╗╔┌─┐┌┬┐┌─┐┌─┐
                                                ╠╩╗│  │ ││     ││├┤   ║║║│ │ │ ├─┤└─┐
                                                ╚═╝┴─┘└─┘└─┘  ─┴┘└─┘  ╝╚╝└─┘ ┴ ┴ ┴└─┘");
              System.Console.WriteLine("Elija una opción: \n");

              for (int i = 0; i < menu_bloc_de_notas.Length; i++)
                {
                    if (i == selected_bloc_de_notas)
                    {
                        Console.BackgroundColor= ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black; 
                    }
                        else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine((i + 1) + ". " + menu_bloc_de_notas[i]);
                    Console.ResetColor();
                }
            }

            void eventos ()
            {
              Console.Clear();
              System.Console.WriteLine(@"
                                                   ╔═╗╦  ╦╔═╗╔╗╔╔╦╗╔═╗╔═╗  
                                                   ║╣ ╚╗╔╝║╣ ║║║ ║ ║ ║╚═╗  
                                                   ╚═╝ ╚╝ ╚═╝╝╚╝ ╩ ╚═╝╚═╝ ");

              System.Console.WriteLine("Elija una opción: \n");

              for (int i = 0; i < menu_eventos.Length; i++)
                {
                    if (i == selectdEvento)
                    {
                        Console.BackgroundColor= ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black; 
                    }
                        else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine((i + 1) + ". " + menu_eventos[i]);
                    Console.ResetColor();
                }
            }
      }
        private static void Agregarcontactos(List<string> Nombres, List<string> Apellidos, List<string> Empresa, List<string> Archivar_como, List<string> Telefono, List<string> Dirección, List<string> Email, List<string> Etiqueta)
        {
          Console.Clear();
          Console.ForegroundColor = ConsoleColor.DarkCyan;
          for (int i = 0; i < 156; i++)
          {
            Console.Write("-");
            Thread.Sleep(10);
          }
          System.Console.WriteLine(@"
                                     ╔═╗╔═╗╦═╗╔═╗╔═╗╦ ╦╔═╗  ╦ ╦╔╗╔  ╔═╗╔═╗╔╗╔╔╦╗╔═╗╔═╗╔╦╗╔═╗  ╔╗╔╦ ╦╔═╗╦  ╦╔═╗
                                     ╠═╣║ ╦╠╦╝║╣ ║ ╦║ ║║╣   ║ ║║║║  ║  ║ ║║║║ ║ ╠═╣║   ║ ║ ║  ║║║║ ║║╣ ╚╗╔╝║ ║ 
                                     ╩ ╩╚═╝╩╚═╚═╝╚═╝╚═╝╚═╝  ╚═╝╝╚╝  ╚═╝╚═╝╝╚╝ ╩ ╩ ╩╚═╝ ╩ ╚═╝  ╝╚╝╚═╝╚═╝ ╚╝ ╚═╝");
          for (int i = 0; i < 156; i++)
          {
           Console.Write("-");
           Thread.Sleep(10);
          }

          System.Console.WriteLine("\n ");
          Console.Write("Nombre: ");
          Nombres.Add(Console.ReadLine()!);
          Console.Write("Apellido: ");
          Apellidos.Add(Console.ReadLine()!);
          Console.Write("Empresa: ");
          Empresa.Add(Console.ReadLine()!);
          Console.Write("Como desea guardar el contacto: ");
          Archivar_como.Add(Console.ReadLine()!);
          Console.Write("Telofono: ");
          Telefono.Add(Console.ReadLine()!);
          Console.Write("Dirección: ");
          Dirección.Add(Console.ReadLine()!);
          Console.Write("Email: ");
          Email.Add(Console.ReadLine()!);
          Console.Write("Etiqueta: ");
          Etiqueta.Add(Console.ReadLine()!);
          Console.Clear();

          for (int i = 0; i < 156; i++)
          {
            Console.Write("-");
            Thread.Sleep(10);
          }
          System.Console.WriteLine(@"
                                           ╔═╗╔═╗  ╔═╗╦ ╦╔═╗╦═╗╔╦╗╔═╗  ╔═╗╔═╗╦═╗╦═╗╔═╗╔═╗╔╦╗╔═╗╔╦╗╔═╗╔╗╔╔╦╗╔═╗
                                           ╚═╗║╣   ║ ╦║ ║╠═╣╠╦╝ ║║║ ║  ║  ║ ║╠╦╝╠╦╝║╣ ║   ║ ╠═╣║║║║╣ ║║║ ║ ║╣ 
                                           ╚═╝╚═╝  ╚═╝╚═╝╩ ╩╩╚══╩╝╚═╝  ╚═╝╚═╝╩╚═╩╚═╚═╝╚═╝ ╩ ╩ ╩╩ ╩╚═╝╝╚╝ ╩ ╚═╝");
          for (int i = 0; i < 156; i++)
          {
            Console.Write("-");
            Thread.Sleep(10);
          }

          System.Console.WriteLine("\n \n \n \n");
           ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Magenta, ConsoleColor.Cyan };

            int currentColor = 0;
          
          while (true)
            {

                Console.ForegroundColor = colors[currentColor];

                Console.Write("\r                                                                  Pulse ENTER para salir ");

                currentColor++;
                if (currentColor >= colors.Length)
                {
                    currentColor = 0;
                }

                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    break;
                }
                System.Threading.Thread.Sleep(500);
            }

        }
        private static void Vercontactos(List<string> Nombres, List<string> Apellidos, List<string> Empresa, List<string> Archivar_como, List<string> Telefono, List<string> Dirección, List<string> Email, List<string> Etiqueta)
        {
          Console.Clear();
          Console.ForegroundColor = ConsoleColor.DarkCyan;
          for (int i = 0; i < 156; i++)
              {
                Console.Write("-");
                Thread.Sleep(10);
              }

              System.Console.WriteLine(@"
                                                ╔═╗╔═╗╔╗╔╔╦╗╔═╗╔═╗╔╦╗╔═╗╔═╗  ╔═╗═╗ ╦╦╔╦╗╔═╗╔╗╔╔╦╗╔═╗╔═╗
                                                ║  ║ ║║║║ ║ ╠═╣║   ║ ║ ║╚═╗  ║╣ ╔╩╦╝║ ║ ║╣ ║║║ ║ ║╣ ╚═╗
                                                ╚═╝╚═╝╝╚╝ ╩ ╩ ╩╚═╝ ╩ ╚═╝╚═╝  ╚═╝╩ ╚═╩ ╩ ╚═╝╝╚╝ ╩ ╚═╝╚═╝");
              for (int i = 0; i < 156; i++)
              {
                Console.Write("-");
                Thread.Sleep(10);
              }

            for (int i = 0; i < Nombres.Count; i++)
            {
              Console.WriteLine("====================" + (i) + "======================");
              Console.WriteLine("Nombre: " + Nombres[i]);
              Console.WriteLine("Apellido: " + Apellidos[i]);
              Console.WriteLine("Empresa: " + Empresa[i]);
              System.Console.WriteLine("Archivado como: " + Archivar_como[i]);
              System.Console.WriteLine("Telefono: " + Telefono[i]);
              System.Console.WriteLine("Dirección: " + Dirección[i]);
              System.Console.WriteLine("Email: " + Email[i]);
              System.Console.WriteLine("Etiqueta: " + Etiqueta[i]);
              Console.WriteLine("========================================");
              System.Console.WriteLine("\n");
            }

              System.Console.WriteLine("\n \n \n \n");
           ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Magenta, ConsoleColor.Cyan };

            int currentColor = 0;
          
            while (true)
            {

              Console.ForegroundColor = colors[currentColor];

              Console.Write("\r                                                                  Pulse ENTER para salir ");

              currentColor++;
              if (currentColor >= colors.Length)
              {
                currentColor = 0;
              }

              if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
              {
                break;
              }
              System.Threading.Thread.Sleep(500);
            }
          
        }

        private static void ver_eventos (List<string> Tipo_de_evento, List<string> Recordatorio_todo_el_dia, List<string> Agregar_personas, List<string> Agregar_una_videoconferencia, List<string> Agregar_Ubicación, List<string> Agregar_Descripcion, List<string> Agregar_archivo_adjunto)
        {
          Console.Clear();
          Console.ForegroundColor = ConsoleColor.DarkCyan;
          for (int i = 0; i < 156; i++)
          {
            Console.Write("-");
            Thread.Sleep(10);
          }

          System.Console.WriteLine(@"
                                             ╔═╗╦  ╦╔═╗╔╗╔╔╦╗╔═╗╔═╗  
                                             ║╣ ╚╗╔╝║╣ ║║║ ║ ║ ║╚═╗   
                                             ╚═╝ ╚╝ ╚═╝╝╚╝ ╩ ╚═╝╚═╝ ");
          for (int i = 0; i < 156; i++)
          {
            Console.Write("-");
            Thread.Sleep(10);
          }
          System.Console.WriteLine("\n \n");
          for (int i = 0; i < Tipo_de_evento.Count; i++)
            {
              Console.WriteLine("====================" + (i) + "======================");
              Console.WriteLine("Tipo de evento: " + Tipo_de_evento[i]);
              Console.WriteLine("Recordatorio del dia completo:: " + Recordatorio_todo_el_dia[i]);
              Console.WriteLine("Personas incluidas: " + Agregar_personas[i]);
              System.Console.WriteLine("VideoConferencia: " + Agregar_una_videoconferencia[i]);
              System.Console.WriteLine("Ubicación: " + Agregar_Ubicación[i]);
              System.Console.WriteLine("Descripción: " + Agregar_Descripcion[i]);
              System.Console.WriteLine("Archivo adjunto: " + Agregar_archivo_adjunto[i]);
              Console.WriteLine("========================================");
              System.Console.WriteLine("\n");
            }

            System.Console.WriteLine("\n \n \n \n");
           ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Magenta, ConsoleColor.Cyan };

            int currentColor = 0;
          
            while (true)
            {

              Console.ForegroundColor = colors[currentColor];

              Console.Write("\r                                                                  Pulse ENTER para salir ");

              currentColor++;
              if (currentColor >= colors.Length)
              {
                currentColor = 0;
              }

              if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
              {
                break;
              }
              System.Threading.Thread.Sleep(500);
            }
        }
        private static void agregareventos (List<string> Tipo_de_evento, List<string> Recordatorio_todo_el_dia, List<string> Agregar_personas, List<string> Agregar_una_videoconferencia, List<string> Agregar_Ubicación, List<string> Agregar_Descripcion, List<string> Agregar_archivo_adjunto)
        {
          Console.Clear();
          Console.ForegroundColor = ConsoleColor.DarkCyan;
          for (int i = 0; i < 156; i++)
          {
            Console.Write("-");
            Thread.Sleep(10);
          }
          System.Console.WriteLine(@"
                                            ┌─┐┌─┐┬─┐┌─┐┌─┐┌─┐┬─┐  ┬ ┬┌┐┌  ┌─┐┬  ┬┌─┐┌┐┌┌┬┐┌─┐  
                                            ├─┤│ ┬├┬┘├┤ │ ┬├─┤├┬┘  │ ││││  ├┤ └┐┌┘├┤ │││ │ │ │  
                                            ┴ ┴└─┘┴└─└─┘└─┘┴ ┴┴└─  └─┘┘└┘  └─┘ └┘ └─┘┘└┘ ┴ └─┘  ");
          for (int i = 0; i < 156; i++)
          {
            Console.Write("-");
            Thread.Sleep(10);
          }
          Console.Write("Tipo de Evento: ");
          Tipo_de_evento.Add(Console.ReadLine()!);

          Console.Write("¿Desea recordar toddo el día? ");
          string repuesta_dia = Console.ReadLine()!;
          if (repuesta_dia == "si")
          {
            string respuesta_dia_si = repuesta_dia;
          }
          Recordatorio_todo_el_dia.Add(repuesta_dia);

          Console.Write("Agregar personas incluidas en el evento: ");
          Agregar_personas.Add(Console.ReadLine()!);

          Console.Write("¿Desea agregar una videoconferencia? ");
          string respuesta = Console.ReadLine()!;

          if (respuesta == "si")
        {
          respuesta = "https://meet.google.com/btf-vumq-wvs";
          string respuestaSi = respuesta;
        }
          Agregar_una_videoconferencia.Add(respuesta);

          Console.Write("¿Desea agregar Ubicación? ");
          string respuesta_ubicación = Console.ReadLine()!;
          if (respuesta_ubicación == "si")
          {
            respuesta_ubicación = "Ubicación guardada";
            //Process.Start("https://www.google.com/");
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = "https://www.google.com/maps/@18.4444492,-69.6571916,15z";
            System.Diagnostics.Process.Start(psi);
          }
          else
          {
            string respuesta_no_ubicacion = respuesta_ubicación;
          }
          Agregar_Ubicación.Add(respuesta_ubicación);

          Console.Write("Descripción: ");
          Agregar_Descripcion.Add(Console.ReadLine()!);

          Console.Write("¿Desea agregar Archivo adjunto? ");
          string repuesta_archivo = Console.ReadLine()!;
          if (repuesta_archivo == "si")
          {
            repuesta_archivo = "Archivo Adjunto";
            Process.Start("explorer.exe", @"C:\ruta\a\la\carpeta");
          }
          else
          {
            string repuesta_no = repuesta_archivo;
          }
         Agregar_archivo_adjunto.Add(repuesta_archivo);   

         for (int i = 0; i < 156; i++)
          {
            Console.Write("-");
            Thread.Sleep(10);
          }
          System.Console.WriteLine(@"
                                           ╔═╗╔═╗  ╔═╗╦ ╦╔═╗╦═╗╔╦╗╔═╗  ╔═╗╔═╗╦═╗╦═╗╔═╗╔═╗╔╦╗╔═╗╔╦╗╔═╗╔╗╔╔╦╗╔═╗
                                           ╚═╗║╣   ║ ╦║ ║╠═╣╠╦╝ ║║║ ║  ║  ║ ║╠╦╝╠╦╝║╣ ║   ║ ╠═╣║║║║╣ ║║║ ║ ║╣ 
                                           ╚═╝╚═╝  ╚═╝╚═╝╩ ╩╩╚══╩╝╚═╝  ╚═╝╚═╝╩╚═╩╚═╚═╝╚═╝ ╩ ╩ ╩╩ ╩╚═╝╝╚╝ ╩ ╚═╝");
          for (int i = 0; i < 156; i++)
          {
            Console.Write("-");
            Thread.Sleep(10);
          }

          System.Console.WriteLine("\n \n \n \n");
           ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Magenta, ConsoleColor.Cyan };

            int currentColor = 0;
          
          while (true)
            {

                Console.ForegroundColor = colors[currentColor];

                Console.Write("\r                                                                  Pulse ENTER para salir ");

                currentColor++;
                if (currentColor >= colors.Length)
                {
                    currentColor = 0;
                }

                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    break;
                }
                System.Threading.Thread.Sleep(500);
            }
        } 

        private static void eliminarcontactos (List<string> Nombres, List<string> Apellidos, List<string> Empresa, List<string> Archivar_como, List<string> Telefono, List<string> Dirección, List<string> Email, List<string> Etiqueta)
        {
          Console.Clear();
          Console.ForegroundColor = ConsoleColor.DarkCyan;
          for (int i = 0; i < 156; i++)
          {
            Console.Write("-");
            Thread.Sleep(10);
          }
          
          System.Console.WriteLine(@"
                                              ┌─┐┬  ┬┌┬┐┬┌┐┌┌─┐┬─┐  ┌─┐┌─┐┌┐┌┌┬┐┌─┐┌─┐┌┬┐┌─┐  
                                              ├┤ │  ││││││││├─┤├┬┘  │  │ ││││ │ ├─┤│   │ │ │  
                                              └─┘┴─┘┴┴ ┴┴┘└┘┴ ┴┴└─  └─┘└─┘┘└┘ ┴ ┴ ┴└─┘ ┴ └─┘ ");
          for (int i = 0; i < 156; i++)
          {
            Console.Write("-");
            Thread.Sleep(10);
          }
            for (int i = 0; i < Nombres.Count; i++)
            {
              Console.WriteLine("====================" + (i) + "======================");
              Console.WriteLine("Nombre: " + Nombres[i]);
              Console.WriteLine("Apellido: " + Apellidos[i]);
              Console.WriteLine("Empresa: " + Empresa[i]);
              System.Console.WriteLine("Archivado como: " + Archivar_como[i]);
              System.Console.WriteLine("Telefono: " + Telefono[i]);
              System.Console.WriteLine("Dirección: " + Dirección[i]);
              System.Console.WriteLine("Email: " + Email[i]);
              System.Console.WriteLine("Etiqueta: " + Etiqueta[i]);
              Console.WriteLine("========================================");
              System.Console.WriteLine("\n");
            }

            System.Console.Write("\n \nIngrese el numero de la persona que quiere eliminar: ");
            string posicionpersonasEliminar = Console.ReadLine()!;
            int x;

          if (int.TryParse(posicionpersonasEliminar, out x))
          {
            int posicionpersonas = int.Parse(posicionpersonasEliminar); 

            if (Nombres.Count <= posicionpersonas || posicionpersonas < 0)
            {
             System.Console.WriteLine("La persona no existe");
            }
            else
            {
              Console.Clear();
             Console.ForegroundColor = ConsoleColor.DarkCyan;
              for (int i = 0; i < 156; i++)
              {
                Console.Write("-");
                Thread.Sleep(10);
              }
             Nombres.RemoveAt(posicionpersonas);
             System.Console.WriteLine(@"
                                                ┌─┐┌─┐┌┐┌┌┬┐┌─┐┌─┐┌┬┐┌─┐  ┌─┐┬  ┬┌┬┐┬┌┐┌┌─┐┌┬┐┌─┐
                                                │  │ ││││ │ ├─┤│   │ │ │  ├┤ │  ││││││││├─┤ │││ │
                                                └─┘└─┘┘└┘ ┴ ┴ ┴└─┘ ┴ └─┘  └─┘┴─┘┴┴ ┴┴┘└┘┴ ┴─┴┘└─┘");
             for (int i = 0; i < 156; i++)
              {
                Console.Write("-");
                Thread.Sleep(10);
              }
            }
                           
          }
          else
          {
           System.Console.WriteLine("Dato Incorrecto");
          }
        }

        private static void editar (List<string> Nombres, List<string> Apellidos, List<string> Empresa, List<string> Archivar_como, List<string> Telefono, List<string> Dirección, List<string> Email, List<string> Etiqueta)
        {
          Console.Clear();
          Console.ForegroundColor = ConsoleColor.DarkCyan;
          int pos_editar;
          for (int i = 0; i < 156; i++)
          {
            Console.Write("-");
            Thread.Sleep(10);
          }

          System.Console.WriteLine(@"
                                            ┌─┐┌┬┐┬┌┬┐┌─┐┬─┐  ┌─┐┌─┐┌┐┌┌┬┐┌─┐┌─┐┌┬┐┌─┐
                                            ├┤  │││ │ ├─┤├┬┘  │  │ ││││ │ ├─┤│   │ │ │
                                            └─┘─┴┘┴ ┴ ┴ ┴┴└─  └─┘└─┘┘└┘ ┴ ┴ ┴└─┘ ┴ └─┘");

          for (int i = 0; i < 156; i++)
          {
            Console.Write("-");
            Thread.Sleep(10);
          }

           for (int i = 0; i < Nombres.Count; i++)
            {
              Console.WriteLine("====================" + (i) + "======================");
              Console.WriteLine("Nombre: " + Nombres[i]);
              Console.WriteLine("Apellido: " + Apellidos[i]);
              Console.WriteLine("Empresa: " + Empresa[i]);
              System.Console.WriteLine("Archivado como: " + Archivar_como[i]);
              System.Console.WriteLine("Telefono: " + Telefono[i]);
              System.Console.WriteLine("Dirección: " + Dirección[i]);
              System.Console.WriteLine("Email: " + Email[i]);
              System.Console.WriteLine("Etiqueta: " + Etiqueta[i]);
              Console.WriteLine("========================================");
              System.Console.WriteLine("\n");
            }

          System.Console.WriteLine("\n \n \n Elija la posicion a editar: ");
          pos_editar = Convert.ToInt32(Console.ReadLine()!);

          Console.Clear();
          Console.ForegroundColor = ConsoleColor.DarkCyan;

          for (int i = 0; i < 156; i++)
          {
            Console.Write("-");
            Thread.Sleep(10);
          }

          System.Console.WriteLine(@"
                                           ┌─┐┌─┐┬─┐┌─┐┌─┐┌─┐┬─┐  ┌┐┌┬ ┬┌─┐┬  ┬┌─┐  ┌─┐┌─┐┌┐┌┌┬┐┌─┐┌─┐┌┬┐┌─┐
                                           ├─┤│ ┬├┬┘├┤ │ ┬├─┤├┬┘  ││││ │├┤ └┐┌┘│ │  │  │ ││││ │ ├─┤│   │ │ │
                                           ┴ ┴└─┘┴└─└─┘└─┘┴ ┴┴└─  ┘└┘└─┘└─┘ └┘ └─┘  └─┘└─┘┘└┘ ┴ ┴ ┴└─┘ ┴ └─┘");

          for (int i = 0; i < 156; i++)
          {
            Console.Write("-");
            Thread.Sleep(10);
          }


          System.Console.WriteLine("\n ");
          Console.Write("Nombre: ");
          
          Nombres[pos_editar] = Console.ReadLine()!;
          Console.Write("Apellido: ");
          
          Apellidos[pos_editar] = Console.ReadLine()!;
          Console.Write("Empresa: ");
          
          Empresa[pos_editar] = Console.ReadLine()!;
          Console.Write("Como desea guardar el contacto: ");
          
          Archivar_como[pos_editar] = Console.ReadLine()!;
          Console.Write("Telofono: ");
          
          Telefono[pos_editar] = Console.ReadLine()!;
          Console.Write("Dirección: ");
          
          Dirección[pos_editar] = Console.ReadLine()!;
          Console.Write("Email: ");
          
          Email[pos_editar] = Console.ReadLine()!;
          Console.Write("Etiqueta: ");
          
          Etiqueta[pos_editar] = Console.ReadLine()!;

          Console.Clear();
          Console.ForegroundColor = ConsoleColor.Red;

          for (int i = 0; i < 156; i++)
          {
            Console.Write("-");
            Thread.Sleep(10);
          }

          System.Console.WriteLine(@"
                                     ┌─┐┬ ┬┌─┐┬─┐┌┬┐┌─┐┌┬┐┌─┐  ┌─┐─┐ ┬┬┌┬┐┌─┐┌─┐┌─┐┌┬┐┌─┐┌┐┌┌┬┐┌─┐
                                     │ ┬│ │├─┤├┬┘ ││├─┤ │││ │  ├┤ ┌┴┬┘│ │ │ │└─┐├─┤│││├┤ │││ │ ├┤ 
                                     └─┘└─┘┴ ┴┴└──┴┘┴ ┴─┴┘└─┘  └─┘┴ └─┴ ┴ └─┘└─┘┴ ┴┴ ┴└─┘┘└┘ ┴ └─┘");
          
          for (int i = 0; i < 156; i++)
          {
            Console.Write("-");
            Thread.Sleep(10);
          }
        }

        private static void editar_evento(List<string> Tipo_de_evento, List<string> Recordatorio_todo_el_dia, List<string> Agregar_personas, List<string> Agregar_una_videoconferencia, List<string> Agregar_Ubicación, List<string> Agregar_Descripcion, List<string> Agregar_archivo_adjunto)
        {
          Console.Clear();
          Console.ForegroundColor = ConsoleColor.DarkCyan;
          int pos_editar_evento;
          for (int i = 0; i < 156; i++)
          {
            Console.Write("-");
            Thread.Sleep(10);
          }
          System.Console.WriteLine(@"
                                            ┌─┐┌┬┐┬┌┬┐┌─┐┬─┐  ┌─┐┬  ┬┌─┐┌┐┌┌┬┐┌─┐
                                            ├┤  │││ │ ├─┤├┬┘  ├┤ └┐┌┘├┤ │││ │ │ │
                                            └─┘─┴┘┴ ┴ ┴ ┴┴└─  └─┘ └┘ └─┘┘└┘ ┴ └─┘");
          for (int i = 0; i < 156; i++)
          {
            Console.Write("-");
            Thread.Sleep(10);
          }
          for (int i = 0; i < Tipo_de_evento.Count; i++)
            {
              Console.WriteLine("====================" + (i) + "======================");
              Console.WriteLine("Tipo de evento: " + Tipo_de_evento[i]);
              Console.WriteLine("Recordatorio del dia completo: " + Recordatorio_todo_el_dia[i]);
              Console.WriteLine("Personas incluidas: " + Agregar_personas[i]);
              System.Console.WriteLine("VideoConferencia: " + Agregar_una_videoconferencia[i]);
              System.Console.WriteLine("Ubicación: " + Agregar_Ubicación[i]);
              System.Console.WriteLine("Descripción: " + Agregar_Descripcion[i]);
              System.Console.WriteLine("Archivo adjunto: " + Agregar_archivo_adjunto[i]);
              Console.WriteLine("========================================");
              System.Console.WriteLine("\n");
            }
          System.Console.WriteLine("\n \n \n Elija la posicion a editar: ");
          pos_editar_evento = Convert.ToInt32(Console.ReadLine()!);

          Console.Clear();
          Console.ForegroundColor = ConsoleColor.DarkCyan;

          for (int i = 0; i < 156; i++)
          {
            Console.Write("-");
            Thread.Sleep(10);
          }
          System.Console.WriteLine(@"
                                            ┌─┐┌─┐┬─┐┌─┐┌─┐┌─┐┬─┐  ┌┐┌┬ ┬┌─┐┬  ┬┌─┐  ┌─┐┬  ┬┌─┐┌┐┌┌┬┐┌─┐
                                            ├─┤│ ┬├┬┘├┤ │ ┬├─┤├┬┘  ││││ │├┤ └┐┌┘│ │  ├┤ └┐┌┘├┤ │││ │ │ │
                                            ┴ ┴└─┘┴└─└─┘└─┘┴ ┴┴└─  ┘└┘└─┘└─┘ └┘ └─┘  └─┘ └┘ └─┘┘└┘ ┴ └─┘");
          for (int i = 0; i < 156; i++)
          {
            Console.Write("-");
            Thread.Sleep(10);
          }
          System.Console.WriteLine("\n ");
          Console.Write("Tipo de evento: ");

          Tipo_de_evento[pos_editar_evento] = Console.ReadLine()!;
          Console.Write("Recordatorio del dia completo: ");

          Recordatorio_todo_el_dia[pos_editar_evento] = Console.ReadLine()!;
          Console.Write("Personas incluidas: ");

          Agregar_personas[pos_editar_evento] = Console.ReadLine()!;
          Console.Write("VideoConferencia: ");

          Agregar_una_videoconferencia[pos_editar_evento] = Console.ReadLine()!;
          Console.Write("¿Desea agregar una Ubiación? ");

          Agregar_Ubicación[pos_editar_evento] = Console.ReadLine()!;
          Console.Write("Descripción: ");

          Agregar_Descripcion[pos_editar_evento] = Console.ReadLine()!;
          Console.Write("Archivo adjunto: ");
          Agregar_archivo_adjunto[pos_editar_evento] = Console.ReadLine()!;

          Console.Clear();
          Console.ForegroundColor = ConsoleColor.Red;

          for (int i = 0; i < 156; i++)
          {
            Console.Write("-");
            Thread.Sleep(10);
          }
          System.Console.WriteLine(@"
                                     ┌─┐┬ ┬┌─┐┬─┐┌┬┐┌─┐┌┬┐┌─┐  ┌─┐─┐ ┬┬┌┬┐┌─┐┌─┐┌─┐┌┬┐┌─┐┌┐┌┌┬┐┌─┐
                                     │ ┬│ │├─┤├┬┘ ││├─┤ │││ │  ├┤ ┌┴┬┘│ │ │ │└─┐├─┤│││├┤ │││ │ ├┤ 
                                     └─┘└─┘┴ ┴┴└──┴┘┴ ┴─┴┘└─┘  └─┘┴ └─┴ ┴ └─┘└─┘┴ ┴┴ ┴└─┘┘└┘ ┴ └─┘");
          
          for (int i = 0; i < 156; i++)
          {
            Console.Write("-");
            Thread.Sleep(10);
          }
        }

        private static void Eliminar_eventos(List<string> Tipo_de_evento, List<string> Recordatorio_todo_el_dia, List<string> Agregar_personas, List<string> Agregar_una_videoconferencia, List<string> Agregar_Ubicación, List<string> Agregar_Descripcion, List<string> Agregar_archivo_adjunto)
        {
           Console.Clear();
          Console.ForegroundColor = ConsoleColor.DarkCyan;
          for (int i = 0; i < 156; i++)
          {
            Console.Write("-");
            Thread.Sleep(10);
          }
          System.Console.WriteLine(@"
                                           ╔═╗╦  ╦╔╦╗╦╔╗╔╔═╗╦═╗  ╔═╗╦  ╦╔═╗╔╗╔╔╦╗╔═╗
                                           ║╣ ║  ║║║║║║║║╠═╣╠╦╝  ║╣ ╚╗╔╝║╣ ║║║ ║ ║ ║
                                           ╚═╝╩═╝╩╩ ╩╩╝╚╝╩ ╩╩╚═  ╚═╝ ╚╝ ╚═╝╝╚╝ ╩ ╚═╝");
          for (int i = 0; i < 156; i++)
          {
            Console.Write("-");
            Thread.Sleep(10);
          }
          for (int i = 0; i < Tipo_de_evento.Count; i++)
            {
              Console.WriteLine("====================" + (i) + "======================");
              Console.WriteLine("Tipo de evento: " + Tipo_de_evento[i]);
              Console.WriteLine("Recordatorio del dia completo: " + Recordatorio_todo_el_dia[i]);
              Console.WriteLine("Personas incluidas: " + Agregar_personas[i]);
              System.Console.WriteLine("VideoConferencia: " + Agregar_una_videoconferencia[i]);
              System.Console.WriteLine("Ubicación: " + Agregar_Ubicación[i]);
              System.Console.WriteLine("Descripción: " + Agregar_Descripcion[i]);
              System.Console.WriteLine("Archivo adjunto: " + Agregar_archivo_adjunto[i]);
              Console.WriteLine("========================================");
              System.Console.WriteLine("\n");
            }
            System.Console.Write("\n \nIngrese el numero de la persona que quiere eliminar: ");
            string posicionpersonasEliminar = Console.ReadLine()!;
            int x;

          if (int.TryParse(posicionpersonasEliminar, out x))
          {
            int posicionpersonas = int.Parse(posicionpersonasEliminar); 

            if (Tipo_de_evento.Count <= posicionpersonas || posicionpersonas < 0)
            {
             System.Console.WriteLine("La persona no existe");
            }
            else
            {
              Console.Clear();
             Console.ForegroundColor = ConsoleColor.DarkCyan;
              for (int i = 0; i < 156; i++)
              {
                Console.Write("-");
                Thread.Sleep(10);
              }
             Tipo_de_evento.RemoveAt(posicionpersonas);
             System.Console.WriteLine(@"
                                              ┌─┐┬  ┬┌─┐┌┐┌┌┬┐┌─┐  ┌─┐┬  ┬┌┬┐┬┌┐┌┌─┐┌┬┐┌─┐
                                              ├┤ └┐┌┘├┤ │││ │ │ │  ├┤ │  ││││││││├─┤ │││ │
                                              └─┘ └┘ └─┘┘└┘ ┴ └─┘  └─┘┴─┘┴┴ ┴┴┘└┘┴ ┴─┴┘└─┘");
             for (int i = 0; i < 156; i++)
              {
                Console.Write("-");
                Thread.Sleep(10);
              }
            }
          }
        }

      private static void Agregar_bloc_de_notas (List<string> asunto, List<string> bloc_de_notas) 
      {
        Console.CursorVisible = true;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        for (int i = 0; i < 156; i++)
        {
          Console.Write("-");
          Thread.Sleep(10);
        }
        System.Console.WriteLine(@"
                                             ╔╗ ┬  ┌─┐┌─┐  ┌┬┐┌─┐  ╔╗╔┌─┐┌┬┐┌─┐┌─┐
                                             ╠╩╗│  │ ││     ││├┤   ║║║│ │ │ ├─┤└─┐
                                             ╚═╝┴─┘└─┘└─┘  ─┴┘└─┘  ╝╚╝└─┘ ┴ ┴ ┴└─┘");
       for (int i = 0; i < 156; i++)
        {
          Console.Write("-");
          Thread.Sleep(10);
        }
        System.Console.WriteLine("\n \nAsunto: ");
        asunto.Add(Console.ReadLine()!);
        System.Console.WriteLine("\n \n");
        System.Console.WriteLine("Escriba su asunto: ");
        bloc_de_notas.Add(Console.ReadLine()!);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        for (int i = 0; i < 156; i++)
        {
          Console.Write("-");
          Thread.Sleep(10);
        }
        System.Console.WriteLine(@"
                                     ┌─┐┬ ┬┌─┐┬─┐┌┬┐┌─┐┌┬┐┌─┐  ┌─┐─┐ ┬┬┌┬┐┌─┐┌─┐┌─┐┌┬┐┌─┐┌┐┌┌┬┐┌─┐
                                     │ ┬│ │├─┤├┬┘ ││├─┤ │││ │  ├┤ ┌┴┬┘│ │ │ │└─┐├─┤│││├┤ │││ │ ├┤ 
                                     └─┘└─┘┴ ┴┴└──┴┘┴ ┴─┴┘└─┘  └─┘┴ └─┴ ┴ └─┘└─┘┴ ┴┴ ┴└─┘┘└┘ ┴ └─┘");
        for (int i = 0; i < 156; i++)
        {
          Console.Write("-");
          Thread.Sleep(10);
        }
        Console.CursorVisible = false;   
      }

      private static void ver_bloc_de_notas(List<string> asunto, List<string> bloc_de_notas)
      {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        for (int i = 0; i < 156; i++)
        {
          Console.Write("-");
          Thread.Sleep(10);
        }
        System.Console.WriteLine(@"
                                             ╔╗ ┬  ┌─┐┌─┐  ┌┬┐┌─┐  ╔╗╔┌─┐┌┬┐┌─┐┌─┐
                                             ╠╩╗│  │ ││     ││├┤   ║║║│ │ │ ├─┤└─┐
                                             ╚═╝┴─┘└─┘└─┘  ─┴┘└─┘  ╝╚╝└─┘ ┴ ┴ ┴└─┘");
       for (int i = 0; i < 156; i++)
        {
          Console.Write("-");
          Thread.Sleep(10);
        }
        for (int i = 0; i < asunto.Count; i++)
        {
         Console.WriteLine("====================" + (i) + "======================");
         Console.WriteLine("Asunto: " + asunto[i]);
         System.Console.WriteLine("\n \n ");
         Console.WriteLine("Escrito de Bloc de Notas: " + bloc_de_notas[i]);
         Console.WriteLine("====================================================================================");
         System.Console.WriteLine("\n");
        }
        System.Console.WriteLine("\n \n \n \n");
        ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Magenta, ConsoleColor.Cyan };

        int currentColor = 0;
          
        while (true)
        {

         Console.ForegroundColor = colors[currentColor];

         Console.Write("\r                                                                  Pulse ENTER para salir ");

         currentColor++;
         if (currentColor >= colors.Length)
          {
            currentColor = 0;
          }

          if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
          {
            break;
          }
          System.Threading.Thread.Sleep(500);
        }
      }
    }
}