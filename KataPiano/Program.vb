Imports System

Module Program

    Sub Main(args As String())

        Dim qtdTeclas = SolicitarTeclas()

        Dim taskPiano = New Task(Sub()

                                     For index = 1 To qtdTeclas
                                         Dim piano As New Piano(index)
                                         Console.WriteLine("Tecla: " & piano.GetCurrentIndex() & "... " & "Color: " & piano.GetColorTecla())
                                     Next

                                 End Sub)

        taskPiano.Start()
        taskPiano.Wait()

    End Sub


    Private Function SolicitarTeclas() As Integer

        Console.Clear()

        Console.WriteLine("Digite a quantidade de teclas a serem pressionadas ...")

        Dim qtdTeclas = Console.ReadLine()

        Dim teclas As Integer

        If Not Integer.TryParse(qtdTeclas, teclas) Then
            Return SolicitarTeclas()
        Else
            Return teclas
        End If

    End Function






End Module
