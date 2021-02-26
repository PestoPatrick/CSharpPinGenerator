# Task - PIN Number Generator #

# Specification #
Specification:
We’d like you to write a program to generate and emit PINs (personal identification <br>
numbers), suitable for use with cash cards, door locks, etc. Each time the program is run it <br>
should emit at least one PIN, according to the following rules:<br>
- Each PIN comprises four numeric digits (e.g. “2845”),<br>
- Your program should not generate “obvious” numbers (such as “1111”),<br>
- Your program should generate the PINs in apparently random order,<br>
- Your program should not repeat a PIN until all the preceding valid PINs have been<br>
emitted - even if the program is stopped and started between PINs.<br>
Within this specification, you have complete freedom to choose your approach:<br>
- Any language is acceptable (provided it’s a real computer language). Any platform is<br>
acceptable.<br>
- You can construct any user interface you feel is appropriate for the task.<br>
- You may interpret the specification in any way you see fit. <br>
<br>

## Design ##
I made the program as a command line interface, as all the feedback the user needs is a single pin number.<br>
Due to the scope of the project, a web interface built with Angular seemed like overkill.

## Classes ##

PinHashTables - Store the hashtables <br>
PinGenerator - The class to generate a valid pin number <br>
DataHandler - The class to save and load data the Pins.json file <br>
Program - Main program entry point <br>


I made the PinHashTables class that held the instances of the two hashtables I <br>
used to store the forbidden pin numbers and the previously generated pins. I <br>
chose to use hashtables as they usually have O(1) efficiency and so as the <br>
number of previously generated numbers grew, it would still efficiently be able <br>
to find if a pin number has already been generated.

## Unit Testing ##
I implemented a unit test to simulate testing my program for a production level <br>
deployment but was not sure how to apply them to my more advanced functions<br>
such as the Data Handling class methods.