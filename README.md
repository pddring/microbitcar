# microbitcar

Instructions:

Connect a micro:bit to your laptop / desktop and flash it with the hex file generated from car_listener.py

Plug this micro:bit into the car.

Get another micro:bit and make sure it has a python program on it. It doesn't matter what the program does, as long as it doesn't use the radio or serial port.

Run TestController and you should be able to control the car.

## Troubleshooting
If no COM ports appear in the list in TestController, you probably haven't got the driver installed for the micro:bit serial port.
Get it from http://microbit-micropython.readthedocs.io/en/latest/devguide/repl.html

##How it works:
The pair of micro:bits communicate using radio signals. The micro:bit in the car listens for the following commands:

"H1": turn headlights on
"H0": turn headlights off
"B1": turn brake lights on
"B0": turn brake lights off
"*1": turn horn on
"*0": turn horn off
"D1": switch door mech on
"D0": switch door mech off
"SF": steer forwards
"SL": steer left
"SR": steer right
"V0": stop
"V-1023": go backwards as fast as possible
"V1023": go forwards as fast as possible

You can vary the number after V to change the speed.