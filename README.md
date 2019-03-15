## latest-holotoolkit attempt
KeywordREcognizerDemo
- Recreate below but with latest version of Unity (2018.3.7f1) and Holotoolkit ()
- Built ok. I'm using .net backend but it'll "be deprecated soon" so shoudl try to switch il2cpp if this works.
- works fine. Warrior is enormous. Char just teleports to new area. Feels like you're barking commands.

DictationTest
- example from holotoolkit. Tap the ball to record, it shows what you've spoken. 
- Works pretty well!

DictationDemo
- Example I built following this tutorial: https://codeholo.com/2018/03/17/dictationexamplehololens/
- Doesn't work at all...don't care.

EffectTest
- doesn't work at all. I'm probably not looking at the leaves...or maybe I'm not 'launching' the prefab correctly...idk what's going on.

## First attempt
First-attempt has code from here: https://codeholo.com/2017/12/03/how-to-use-voice-input-in-hololens/

Using this setup: https://codeholo.com/2017/12/01/integrating-mixed-reality-toolkit-in-your-hololens-apps/

But it fails to build (looks like it has the wrong build/deploy settings for talking to the Hololens). Also I was not able to select ".NET" as scripting backend, or select "Unitiy C# projects" for unknown reasons.

I'd like to start over w/ latest version of MRTK.

And I'd like to get to this example of dictation: https://codeholo.com/2018/03/17/dictationexamplehololens/

But first wanna check keyword input and get some baseline working, and see how flexible it is (can a keyword be an entire sentence?)
