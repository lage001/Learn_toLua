


print("---------- Test.lua ")
A = {}

function A:new(o,a,name)
    o = o or {}
    setmetatable(o,self)
    self.__index = self
    self.a = a or 0
    self.name = name or ""
    
    return o
end

function A:B()
    print(self.a)
end

a = A:new(nil,1,"a")

print(a.a)


