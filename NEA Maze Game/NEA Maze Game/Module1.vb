Imports System
Imports System.Timers
Module Module1
    Sub Main()
        Dim Choice As Integer
        Console.WriteLine("DO YOU WANT TO HAVE EASY BANK UPGRADE ON? - This is very annoying  (Y/N)")
        Dim input As String = Console.ReadLine()
        If LCase(input) = "y" Or LCase(input) = "yes" Then
            Choice = 1
        Else
            Choice = 0
        End If
        Console.Clear()

        Console.WriteLine("What do you want to spam")
        Dim text As String = Console.ReadLine()
        Console.WriteLine("How many times?")
        Dim count As Integer = Console.ReadLine()
        Console.WriteLine("Whats the Time interval (In Seconds? - do 0 for a constant spam)")
        Dim time As Integer = Console.ReadLine
        Console.Clear()

        Console.WriteLine("                       >>> PLEASE READ!! <<<")
        Console.WriteLine("")
        Console.WriteLine(">>> Click on this console. <<<")
        Console.WriteLine(">>> once you press any key the code will start to run. <<< ")
        Console.WriteLine(">>> You will have 2 seconds to click on the text bar/ application you want to inject. <<<")
        Console.WriteLine(">>> Then the program will start to run. <<<")
        Console.WriteLine("")
        Console.WriteLine(">>> Press any key to begin. <<<")

        Console.ReadKey()
        Console.Clear()
        System.Threading.Thread.Sleep(2000)

        Dim tick As Integer = 0

        If Choice = 1 Then ' This is the easy bank increase
            Do
                tick += 1

                My.Computer.Keyboard.SendKeys(text, True)

                My.Computer.Keyboard.SendKeys("{enter}", True)
                System.Threading.Thread.Sleep(1000)
                My.Computer.Keyboard.SendKeys("pls deposit all", True)

                My.Computer.Keyboard.SendKeys("{enter}", True)
                System.Threading.Thread.Sleep(1000)
                My.Computer.Keyboard.SendKeys("pls inv", True)

                My.Computer.Keyboard.SendKeys("{enter}", True)
                System.Threading.Thread.Sleep(1000)
                My.Computer.Keyboard.SendKeys("pls bal", True)

                My.Computer.Keyboard.SendKeys("{enter}", True)
                System.Threading.Thread.Sleep(1000)
                My.Computer.Keyboard.SendKeys("pls pet", True)

                My.Computer.Keyboard.SendKeys("{enter}", True)
                System.Threading.Thread.Sleep(1000)
                My.Computer.Keyboard.SendKeys("pls profile", True)

                My.Computer.Keyboard.SendKeys("{enter}", True)
                'System.Threading.Thread.Sleep(750)
                'My.Computer.Keyboard.SendKeys("pls hunt", True)

                'My.Computer.Keyboard.SendKeys("{enter}", True)
                System.Threading.Thread.Sleep(1000)
                My.Computer.Keyboard.SendKeys("pls fish", True)

                My.Computer.Keyboard.SendKeys("{enter}", True)
                System.Threading.Thread.Sleep(1000)

                'My.Computer.Keyboard.SendKeys("pls share @Feminist Wga 1", True)

                'My.Computer.Keyboard.SendKeys("{enter}", True)

                'My.Computer.Keyboard.SendKeys("pls postmemes", True)

                'My.Computer.Keyboard.SendKeys("{enter}", True)

                ' My.Computer.Keyboard.SendKeys("d", True)

                'My.Computer.Keyboard.SendKeys("{enter}", True)

                For i = time To 1 Step -1

                    System.Threading.Thread.Sleep(1000)
                    Console.Clear()
                    Console.Write($" >{i}< Seonds until injection")

                Next

            Loop Until tick = count
        Else

            Do
                tick += 1

                My.Computer.Keyboard.SendKeys(text, True)

                My.Computer.Keyboard.SendKeys("{enter}", True)

                For i = time To 1 Step -1

                    System.Threading.Thread.Sleep(1000)
                    Console.Clear()
                    Console.Write($" >{i}< Seonds until injection")

                Next
            Loop Until tick = count
        End If


        'AppActivate("Discord.exe")
        'Dim procID As Integer
        'procID = Shell("C:\Users\georg\AppData\Local\Discord\app-0.0.308.exe", AppWinStyle.NormalFocus)




    End Sub




End Module






