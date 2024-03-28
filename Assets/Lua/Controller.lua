local Input = UnityEngine.Input
local GameObject = UnityEngine.GameObject
local Rigidbody = UnityEngine.Rigidbody



Controller = {}

function Controller:Start()
	self.rb = GameObject.Find("Sphere"):GetComponent(typeof(Rigidbody))
	M:func()
end

function Controller:Update()
	local x = Input.GetAxis("Horizontal")
	local y = Input.GetAxis("Vertical")
	local force = 2
	self.rb:AddForce(x * force, 0, y * force)
end

function Start()
	
end

function Update()
	Controller:Update()
end


