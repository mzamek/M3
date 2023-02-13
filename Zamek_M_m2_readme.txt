Name: Mark Zamek
E-mail: mzamek3@gatech.edu
OIT Account: mzamek3
Brief Description of my changes:

1.) Your name appears in the HUD
---> Works as specified
2.) three (3) blue rigidbody spheres with collision sounds
---> found under hierarchy->blueSphere Parent
3.) three (3) red rigidbody spheres that don’t collide with one another
---> found under hierarchy->redSphere Parent
4.) Asset Store model “Free Japanese Mask” with custom compound collider
---> found under hierarchy->Kitsune
5.) yellow jointed chain made of at least five (5) rigidbody GameObjects
---> found under hierarchy->hangingThing(to the right of minions)
6.) blue kinematic rigidbody elevator using Mecanim animation with red rigidbody sphere going for a ride
---> found under hierarchy->elevatorRoot(behind minions, to the right)
7.) green Weeble Wobble/Punching Bozo that tilts but can’t be knocked over
---> found under hierarchy->Weeble(behind minions, to the right)
8.) a purple cube with rigidbody box that does not slide down the ramp
---> found under hierarchy->Weeble(behind minions, to the right)
9.) green cube with rigidbody box that does slide down the ramp
---> found under hierarchy->customFrictionCube
10.) orange rigidbody sphere that bounces
---> found under hierarchy->orangeBouncySphere
11.) Y_Bot ragdoll that collapses over the hurdle
---> found under hierarchy->Y_Bot
12.) black click beetle or jumping bean that jumps intermittently. There should be a variable/random amount of time between jumps and variable/random force magnitude and direction. Jumps only happen when grounded.
---> found under hierarchy->jumpingBean
### impulse is set upwards and slightly angled in random direction. Force is random, bound by Impulse Force Multiplier that is now set to 5.
### torque is in random direction and random impulse bound by Impulse Torque Multiplier that is set to 2.
### time delay between jumps is random and is bound by Time Delay that is set to 4 seconds.
13.) Make a pause script that starts the game paused and unpauses with “p” keypress
---> found under hierarchy->timePause inside script attached to this empty object
14.) submit project according to submission requirements (Make sure you pass audit)
---> done