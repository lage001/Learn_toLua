require("TestLua")
require("Controller")
require("TestA")
Main = {}
function Main.Start()
	Controller:Start()
end

function Main.Update()
	Controller:Update()
end


--场景切换通知
--function OnLevelWasLoaded(level)
--	collectgarbage("collect")
--	Time.timeSinceLevelLoad = 0
--end

--function OnApplicationQuit()
--end