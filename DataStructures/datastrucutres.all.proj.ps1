#Set-ExecutionPolicy -ExecutionPolicy RemoteSigned
$scriptDirectory = (Get-Item $MyInvocation.MyCommand.Path).Directory.FullName
$dteObj = New-Object -ComObject "VisualStudio.DTE.14.0"

$slnDir = ".\"
$slnName = "Data Structures"

$dteObj.Solution.Create($scriptDirectory, $slnName)
(ls . -Recurse *.csproj) | % { $dteObj.Solution.AddFromFile($_.FullName, $false) }
$dteObj.Solution.SaveAs( (Join-Path $scriptDirectory 'Data Structures.sln') ) 
$dteObj.Quit()

ls -in *.sln -r | select -last 1 | %{ ii $_.FullName }