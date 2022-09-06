function GetSuggestions(outputIn)
	dim arWords,arSugg
	dim retVal
	retVal = ""
	output = outputIn
	'"fxsearch([""insurance"",[""life insurance corporation of india"",""reliance insurance"",""insurance institute of india"",""health insurance"",""national insurance""],[],[]])"
	output = replace(output,"fxsearch","")
	output = replace(output,"([","")
	output = replace(output,"])","")
	output = replace(output, """" + word + """," ,"")
	output = replace(output,",[]","")
	
	output = replace(output,"[""","""")
	output = replace(output,"""]","""")
	retVal = replace(output,"""","")
	GetSuggestions = retVal

end function

function GetURL(Word)

	GetURL = "http://sugg.search.yahoo.net/sg/?output=fxjsonp&nresults=10&command=" + word
end function