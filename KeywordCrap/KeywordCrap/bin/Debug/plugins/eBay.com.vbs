function GetSuggestions(outputIn)
	dim arWords,arSugg
	dim retVal
	retVal = ""
	output = outputIn
	'output = "vjo.darwin.domain.finding.autofill.AutoFill._do( [	""data"",	[""data logger"",""datavideo"",""casio databank"",""data collector"",""datacard"",""kingston data traveler"",""garmin data card""],	[		["" "",""f"",0],		["" mes"",""f"",1],		[""base.sql"",""f"",2]	] ])"
	nPos1 = instr(1,output,"[""")
	nPos2 = instr(nPos1,output,"""]")
	retVal = Mid(output,nPos1 , nPos2 - nPos1 + 2)
	retVal = replace(retVal,"""]","")
	retVal = replace(retVal,"[""","")
	retVal = replace(retVal,""",""",",")
	GetSuggestions = retVal

end function



function GetURL(Word)
	dim ch,baseURL

	baseURL = "http://include.ebaystatic.com/autofill/f/0/1246954105"
	for i=1 to len(word)
		ch = mid(word,i,1)
		baseurl = baseurl + "/" + ch
	next
	baseURL = baseURL + ".js"
	GEtURL = baseURL
end function