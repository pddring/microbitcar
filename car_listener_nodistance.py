from microbit import *
import radio
import music

radio.on()
display.off()

class Car:
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

    cmd = str(msg)[0]
    param = str(msg)[1:]
    #display.on()
    #print("RX: " + cmd + ": " + param)

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

    except Exception as e:
        print(e)
        car.stop()
        display.on()
        display.show(cmd)
        sleep(1000)
        display.show(param)
        sleep(1000)
        display.off()
