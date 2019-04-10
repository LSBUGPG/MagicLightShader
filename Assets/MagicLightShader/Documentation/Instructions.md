# Magic light shader

This shader is a standard Unity shader except that it takes the alpha value of any light that is shining on it. That is, if there is no light shining on it (or no alpha in the colour of the light shining on it) then it will be invisible.

## Usage

Apply the magic light material to any object you wish to hide. Shine any light with an alpha colour component to reveal the object. Your magic light material should have a colour with an alpha component of 0 otherwise it will show up even without a light on it. Your light should have maximum alpha otherwise it won't show up hidden objects.

The shader parameter `Amplification` controls how much the surface alpha amplifies the light falling on it. The higher the value, the less light you need to make the object show up.

## How it works

This shader is a standard Unity surface shader with a custom lighting function. The lighting function is modified from the SimpleLambert shader given in the Unity documentation:
https://docs.unity3d.com/Manual/SL-SurfaceShaderLightingExamples.html

Whereas that shader takes its alpha component from the surface data, this shader uses the lighting calculation itself to add to the existing alpha.

The tags were modified so that it would render as a transparent shader. And the alpha:fade option was added to allow it to go fully transparent.