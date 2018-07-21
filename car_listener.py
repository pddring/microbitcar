# This file goes on a micro:bit inside the car. It listens for radio commands
from microbit import *
display.off()

def set_speed(speed):
  if abs(speed) < 10:
    pin0.write_analog(0)
  else:
    pin0.write_analog(abs(speed))
    if speed > 0:
      pin8.write_digital(0)
    else:
      pin8.write_digital(1)

def steer(direction):
  if direction=="L":
    pin12.write_digital(1)
    pin16.write_digital(0)
  elif direction == "R":
    pin12.write_digital(0)
    pin16.write_digital(1)
  else:
    pin12.write_digital(0)
    pin16.write_digital(0)

while True:
  if button_a.is_pressed():
    steer("L")
  elif button_b.is_pressed():
    steer("R")
  else:
    steer("F")
    
  speed = -accelerometer.get_y()
  set_speed(speed)
  
  sleep(10)
