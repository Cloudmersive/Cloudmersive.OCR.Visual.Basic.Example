Imports Cloudmersive.APIClient.NET.OCR.Api
Imports Cloudmersive.APIClient.NET.OCR.Client
Imports Cloudmersive.APIClient.NET.OCR.Model

Module Module1

    Sub Main()
        Configuration.Default.AddApiKey("Apikey", "YOUR-API-KEY-HERE")



        Dim apiInstance = New ImageOcrApi()
        Dim imageFile = New System.IO.FileStream("C:\\temp\\nytimes.png", System.IO.FileMode.Open)
        Dim language = "ENG"
        Dim preprocessing = "Auto"

        Dim result = apiInstance.ImageOcrPost(imageFile, language, preprocessing)
        Debug.WriteLine(result)
    End Sub

End Module
