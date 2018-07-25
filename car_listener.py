from microbit import *
import radio
radio.on()
display.off()

def stop():
    pin0.write_analog(0)
    pin8.write_digital(0)
    pin12.write_digital(0)
    pin16.write_digital(0)
    pin6.write_digital(0)
    pin7.write_digital(0)
    pin3.write_digital(0)
    pin9.write_digital(0)

stop()
while True:
    msg = radio.receive()
    if msg == None:
        sleep(50)
    else:
        
        cmd = str(msg)[0]
        param = str(msg)[1:]
      
        try:
            # headlights
            if cmd == "H":
                value = int(param)
                pin6.write_digital(value)
            
            # horn
            if cmd == "*":
                value = int(param)
                pin3.write_digital(value)

            # rear lights
            if cmd == "B":
                value = int(param)
                pin7.write_digital(value)

            # doors
            if cmd == "D":
                value = int(param)
                pin9.write_digital(value)

            # set speed
            if cmd == "V":
                value = int(param)
                if value >= 0:
                    pin8.write_digital(0)
                else:
                    pin8.write_digital(1)
                pin0.write_analog(abs(value))

            # steer
            if cmd == "S":
                if param == "L":
                    pin12.write_digital(1)
                    pin16.write_digital(0)
                elif param == "R":
                    pin12.write_digital(1)
                    pin16.write_digital(1)
                else:
                    pin12.write_digital(0)
                    pin16   .write_digital(0)
                
        except:
            stop()
            display.on()
            display.show(cmd)
            sleep(1000)
            display.show(param)
            sleep(1000)
            display.off()