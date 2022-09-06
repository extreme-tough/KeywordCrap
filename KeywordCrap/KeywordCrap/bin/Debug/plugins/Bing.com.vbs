function GetSuggestions(outputIn)
	dim arWords,arSugg
	dim retVal
	dim nPos1, sWord
	retVal = ""
	output =  outputIn
	'output = "if(typeof sa_inst.setData == 'function') sa_inst.setData({""SearchSuggestion"":{""Query"":""data"",""Section"":[{""Text"":""data""},{""Text"":""database""},{""Text"":""dataone""},{""Text"":""data entry""},{""Text"":""data recovery""},{""Text"":""data entry jobs""},{""Text"":""dataquick""},{""Text"":""data bg""},{""Text"":""data mining""},{""Text"":""datascope""}]}} /* pageview_candidate */);"
	nPos1=1
	Do while (true)
		nPos1 = Instr(nPos1,output,"""Text"":""")
		if nPos1 = 0 then exit do
		nPos2 = Instr(nPos1 + 8,output,"""")
		sWord = Mid(output,nPos1+8, nPos2 - nPos1 - 8)
		nPos1 = nPos2
		if sWord<>"" then
			if retVal="" then
				retVal = sWord  
			else
				retVal = retVal + "," + sWord  
			end if
		end if
	Loop
	GetSuggestions = retVal

end function

function GetURL(Word)
	
	GetURL =  "http://api.bing.com/qson.aspx?market=en-US&JsonType=callback&JsonCallback=sa_inst.setData&query=" + word

end function