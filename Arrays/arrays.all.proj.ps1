#Set-ExecutionPolicy -ExecutionPolicy RemoteSigned

$scriptDirectory = (Get-Item $MyInvocation.MyCommand.Path).Directory.FullName
$dteObj = New-Object -ComObject "VisualStudio.DTE.15.0"

$slnDir = ".\"
$slnName = "Arrays"

$dteObj.Solution.Create($scriptDirectory, $slnName)
(ls . -Recurse *.csproj) | % { $dteObj.Solution.AddFromFile($_.FullName, $false) }
$dteObj.Solution.SaveAs( (Join-Path $scriptDirectory 'Arrays.sln') )
$dteObj.Quit()

ls -in *.sln -r | select -last 1 | %{ ii $_.FullName }