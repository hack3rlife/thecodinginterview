#Set-ExecutionPolicy -ExecutionPolicy RemoteSigned

$scriptDirectory = (Get-Item $MyInvocation.MyCommand.Path).Directory.FullName
$dteObj = New-Object -ComObject "VisualStudio.DTE.14.0"

$slnDir = ".\"
$slnName = "The Coding Interview"

#$writer = new-object System.IO.StreamWriter ($scriptDirectory, $false, [System.Text.Encoding]::UTF8)
#$writer.WriteLine("Microsoft Visual Studio Solution File, Format Version 14.00")
#$writer.WriteLine("Creating solution {0}", $slnName)

$dteObj.Solution.Create($scriptDirectory, $slnName)
(ls . -Recurse *.csproj) | % { $dteObj.Solution.AddFromFile($_.FullName, $false) }
$dteObj.Solution.SaveAs( (Join-Path $scriptDirectory 'The Coding Interview.sln') )
$dteObj.Quit()


ls -in *.sln -r | select -last 1 | %{ ii $_.FullName }