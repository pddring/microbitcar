from microbit import *
import radio
import music
import ustruct
radio.on()
display.off()

class DistanceSensor:
    I2C_ADDRESS = 0x29
    VL53L0X_START	            		        = 0x0000
    VL53L0X_STATUS                  		    = 0x0014
    last_distance = 0
    
    def byteswap(self, val):
        return struct.unpack('<H', ustruct.pack('>H', val))[0]
    def makeuint16(self, lsb, msb):
        return ((msb << 8)  + (lsb))
    def writeReg(self, address, data):
        i2c.write(self.I2C_ADDRESS,bytearray([address, data]))
    def readReg(self, address):
        i2c.write(self.I2C_ADDRESS,bytearray([address]))
        tempByte = i2c.read(self.I2C_ADDRESS,1)
        return ustruct.unpack('<I', tempByte)[0]

    def get(self):
        self.writeReg(self.VL53L0X_START, 0x01)
        cnt = 0
        while (cnt < 100): 
            sleep(0.010)
            val = self.readReg(self.VL53L0X_STATUS)
            if (val & 0x01):
                break
            cnt += 1
        i2c.write(self.I2C_ADDRESS,bytearray([0x14,12]))
        data = i2c.read(self.I2C_ADDRESS,12)
        DeviceRangeStatusInternal = ((data[0] & 0x78) >> 3)
        if DeviceRangeStatusInternal == 11:
            distanceMM = self.makeuint16(data[11], data[10])-45
            dist = int (distanceMM)
            self.last_distance = dist
            return dist
        return self.last_distance

class Car:
    distance = DistanceSensor()
    def stop(self):
        pin0.write_analog(0)
        pin8.write_digital(0)
        pin12.write_digital(0)
        pin16.write_digital(0)
        pin6.write_digital(0)
        pin7.write_digital(0)
        pin3.write_digital(0)
        pin9.write_digital(0)
    
    def set_headlights(self, value):
        pin6.write_digital(value)
        
    def set_horn(self, value):
        music.pitch(value, 1000, pin3)
        pin3.write_digital(0)
        
    def set_rear_lights(self, value):
        pin7.write_digital(value)
        
    def set_doors(self, value):
        pin9.write_digital(value)
        
    def set_speed(self, value):
        if value >= 0:
            pin8.write_digital(0)
        else:
            pin8.write_digital(1)
        pin0.write_analog(abs(value))
        
    def steer(self, param):
        if param == "L":
            pin12.write_digital(1)
            pin16.write_digital(0)
        elif param == "R":
            pin12.write_digital(1)
            pin16.write_digital(1)
        else:
            pin12.write_digital(0)
            pin16.write_digital(0)

car = Car()
car.stop()

while True:
    msg = radio.receive()
    if msg == None:
        car.distance.get()
    else:
        
        cmd = str(msg)[0]
        param = str(msg)[1:]
        #display.on()
        print("RX: " + cmd + ": " + param)
        
        #display.off()
        try:
            # headlights
            if cmd == "H":
                value = int(param)
                car.set_headlights(value)
            
            # horn
            if cmd == "*":
                value = int(param)
                car.set_horn(value)
                
            # rear lights
            if cmd == "B":
                value = int(param)
                car.set_rear_lights(value)

            # doors
            if cmd == "D":
                value = int(param)
                car.set_doors(value)

            # set speed
            if cmd == "V":
                value = int(param)
                car.set_speed(value)

            # steer
            if cmd == "S":
                car.steer(param)
                
            # Get distance
            if cmd == "G":
                if param == "d":
                    radio.send(str(car.distance.last_distance))
                
        except Exception as e:
            print(e)
            car.stop()
            display.on()
            display.show(cmd)
            sleep(1000)
            display.show(param)
            sleep(1000)
            display.off()