function GetSuggestions(outputIn)
	dim arWords,arSugg
	dim retVal,npos
	retVal = ""
	output = outputIn
	'output = "[""harry potter"",[""harry potter box set"",""harry potter and the half blood prince"",""harry potter and the deathly hallows"",""harry potter dvd"",""harry potter books"",""harry potter and the order of the phoenix"",""harry potter blu ray"",""harry potter and the sorcerer's stone"",""harry potter audio book"",""harry potter and the goblet of fire""],[],[]]"
	npos = instr(1,output,",[""")
	output = mid(output,npos)
	output = replace(output, ",[","")
	output = replace(output, "],[],[]]","")
	output = replace(output, "]","")
	output = replace(output, "[","")
	output = replace(output, """","")
	GetSuggestions = output

end function



function GetURL(Word)

	GetURL = "http://completion.amazon.com/search/complete?method=completion&q=" + word + "&search-alias=aps&mkt=1" 

end function