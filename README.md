## Second attempt
- Recreate below but with latest version of Unity (2018.3.7f1) and MRTK ()
- Built ok. Next steps: finish adding to git and test on hololens. I'm using .net backend but it'll "be deprecated soon" so shoudl try to switch il2cpp if this works.

## First attempt
First-attempt has code from here: https://codeholo.com/2017/12/03/how-to-use-voice-input-in-hololens/

Using this setup: https://codeholo.com/2017/12/01/integrating-mixed-reality-toolkit-in-your-hololens-apps/

But it fails to build (looks like it has the wrong build/deploy settings for talking to the Hololens). Also I was not able to select ".NET" as scripting backend, or select "Unitiy C# projects" for unknown reasons.

I'd like to start over w/ latest version of MRTK.

And I'd like to get to this example of dictation: https://codeholo.com/2018/03/17/dictationexamplehololens/

But first wanna check keyword input and get some baseline working, and see how flexible it is (can a keyword be an entire sentence?)
