function GetSuggestions(outputIn)
	dim arWords,arSugg
	dim retVal
	retVal = ""
	output = outputIn
	'output = "window.google.ac.h([""insurance"",[[""insurance institute of india"",""445,000 results"",""0""],[""insurance companies in india"",""8,380,000 results"",""1""],[""insurance institute"",""18,100,000 results"",""2""],[""insurance companies"",""53,300,000 results"",""3""],[""insurance sector in india"",""1,460,000 results"",""4""],[""insurance sector"",""18,300,000 results"",""5""],[""insurance in india"",""62,300,000 results"",""6""],[""insurance industry"",""45,800,000 results"",""7""],[""insurance regulatory development authority"",""739,000 results"",""8""],[""insurance ombudsman"",""251,000 results"",""9""]]])"
	output = replace(output,"window.google.ac.h","")
	output = replace(output,"([","")
	output = replace(output,"])","")
	output = replace(output, """" + word + """," ,"")
	output = replace(output,"[[","[")
	output = replace(output,"]]","]")
	arWords = Split(output, "],[")
	For i = 0 to UBound(arWords)
		arWords(i)  = replace(arWords(i),"[""","""")
		arWords(i)  = replace(arWords(i),"""]","""")
		arSugg = split(arwords(i),",")
		arSugg(0) = replace(arSugg(0),"""","")
		if retVal="" then
			retVal = arSugg(0) 
		else
			retVal = retVal + "," + arSugg(0) 
		end if
	Next
	GetSuggestions = retVal

end function



function GetURL(Word)

	GetURL = "http://clients1.google.com/complete/search?hl=en&q=" & word 

end function