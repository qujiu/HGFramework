--
-- Autogenerated by Thrift
--
-- DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
-- @generated
--


require 'Thrift'
require 'config_constants'

HeroInfoConfig = __TObject:new{
  description,
  defend,
  attack,
  model,
  id,
  name
}

function HeroInfoConfig:read(iprot)
  iprot:readStructBegin()
  while true do
    local fname, ftype, fid = iprot:readFieldBegin()
    if ftype == TType.STOP then
      break
    elseif fid == 1 then
      if ftype == TType.STRING then
        self.description = iprot:readString()
      else
        iprot:skip(ftype)
      end
    elseif fid == 2 then
      if ftype == TType.I32 then
        self.defend = iprot:readI32()
      else
        iprot:skip(ftype)
      end
    elseif fid == 3 then
      if ftype == TType.I32 then
        self.attack = iprot:readI32()
      else
        iprot:skip(ftype)
      end
    elseif fid == 4 then
      if ftype == TType.STRING then
        self.model = iprot:readString()
      else
        iprot:skip(ftype)
      end
    elseif fid == 5 then
      if ftype == TType.STRING then
        self.id = iprot:readString()
      else
        iprot:skip(ftype)
      end
    elseif fid == 6 then
      if ftype == TType.STRING then
        self.name = iprot:readString()
      else
        iprot:skip(ftype)
      end
    else
      iprot:skip(ftype)
    end
    iprot:readFieldEnd()
  end
  iprot:readStructEnd()
end

function HeroInfoConfig:write(oprot)
  oprot:writeStructBegin('HeroInfoConfig')
  if self.description then
    oprot:writeFieldBegin('description', TType.STRING, 1)
    oprot:writeString(self.description)
    oprot:writeFieldEnd()
  end
  if self.defend then
    oprot:writeFieldBegin('defend', TType.I32, 2)
    oprot:writeI32(self.defend)
    oprot:writeFieldEnd()
  end
  if self.attack then
    oprot:writeFieldBegin('attack', TType.I32, 3)
    oprot:writeI32(self.attack)
    oprot:writeFieldEnd()
  end
  if self.model then
    oprot:writeFieldBegin('model', TType.STRING, 4)
    oprot:writeString(self.model)
    oprot:writeFieldEnd()
  end
  if self.id then
    oprot:writeFieldBegin('id', TType.STRING, 5)
    oprot:writeString(self.id)
    oprot:writeFieldEnd()
  end
  if self.name then
    oprot:writeFieldBegin('name', TType.STRING, 6)
    oprot:writeString(self.name)
    oprot:writeFieldEnd()
  end
  oprot:writeFieldStop()
  oprot:writeStructEnd()
end

HeroInfoConfigMap = __TObject:new{
  configMap
}

function HeroInfoConfigMap:read(iprot)
  iprot:readStructBegin()
  while true do
    local fname, ftype, fid = iprot:readFieldBegin()
    if ftype == TType.STOP then
      break
    elseif fid == 1 then
      if ftype == TType.MAP then
        self.configMap = {}
        local _ktype1, _vtype2, _size0 = iprot:readMapBegin() 
        for _i=1,_size0 do
          local _key4 = iprot:readString()
          local _val5 = HeroInfoConfig:new{}
          _val5:read(iprot)
          self.configMap[_key4] = _val5
        end
        iprot:readMapEnd()
      else
        iprot:skip(ftype)
      end
    else
      iprot:skip(ftype)
    end
    iprot:readFieldEnd()
  end
  iprot:readStructEnd()
end

function HeroInfoConfigMap:write(oprot)
  oprot:writeStructBegin('HeroInfoConfigMap')
  if self.configMap then
    oprot:writeFieldBegin('configMap', TType.MAP, 1)
    oprot:writeMapBegin(TType.STRING, TType.STRUCT, ttable_size(self.configMap))
    for kiter6,viter7 in pairs(self.configMap) do
      oprot:writeString(kiter6)
      viter7:write(oprot)
    end
    oprot:writeMapEnd()
    oprot:writeFieldEnd()
  end
  oprot:writeFieldStop()
  oprot:writeStructEnd()
end