function GetSuggestions(outputIn)
	dim arWords,arSugg
	dim retVal
	retVal = ""
	output = outputIn
	'output = "window.google.ac.hry([""funny"",[[""funny jokes"",""11,400,000 results"",""0""],[""funny quotes"",""8,270,000 results"",""1""],[""funny games"",""32,000,000 results"",""2""],[""funny pictures"",""61,800,000 results"",""3""],[""funny or die"",""77,800,000 results"",""4""],[""funny sayings"",""865,000 results"",""5""],[""funny pics"",""81,500,000 results"",""6""],[""funny poems"",""1,070,000 results"",""7""],[""funny pick up lines"",""809,000 results"",""8""],[""funny names"",""13,500,000 results"",""9""]]])"
	output = replace(output,"window.google.ac.hry","")
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

	GetURL = "http://suggestqueries.google.com/complete/search?hl=en&jsonp=window.google.ac.hry&q=" & word

end function