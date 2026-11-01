# Embodiment
### An immersive collaborative experience using biofeedback

**Embodiment** is an experimental VR installation exploring the possibility of two people sharing one body.

How would it feel if your body and another person's became interconnected? If your breathing, movements and perceptions were no longer entirely your own?

The experience brings two participants together inside an immersive underwater environment. Through wearable sensors, their breathing is measured in real time and translated into the behaviour of a shared virtual body: a whale navigating through the ocean.

The participants must coordinate their breathing to stabilise and steer the creature. Their individual bodily rhythms become part of a shared system, creating an experience in which cooperation is not simply a social choice but a condition of movement and survival.
<img width="512" height="340" alt="image" src="https://github.com/user-attachments/assets/f1c1d370-82f8-462b-8f1a-f32e02fba6df" />

## Concept and interaction

The experience explores three dimensions of human embodiment: **body, heart and mind**.

The prototype focuses on breathing synchronisation. Each participant wears a custom-built belt equipped with a flex sensor that detects the expansion and contraction of the abdomen.

The resulting sensor data influences the virtual environment and the participants' shared interaction.

- Two participants collaboratively control a single virtual body.
- Each participant controls one side of the creature.
- Breathing measurements influence the tilt of the whale's flippers.
- The whale's movement emerges from the coordination of both participants.
- The synchronisation of their breathing also influences the visual relationship between their individual representations.

## Technical implementation

I was responsible for the software development of the project, including the Unity interaction systems, signal processing, networking logic and shader experimentation.

The implementation combines:

- **Unity and C#:** Real-time interaction, movement systems and integration of biofeedback.
- **Signal processing:** Buffering, smoothing, normalisation and analysis of incoming sensor signals.
- **Arduino integration:** Receiving and processing physical sensor measurements.
- **Photon networking:** Synchronising participant data and interactions.
- **Shader programming:** Experimental raymarching shaders that dynamically merge and separate visual representations according to breathing synchronisation.
- **VR installation:** Development for an immersive CAVE environment.

The physical sensing and wireless Arduino communication were developed collaboratively.

## Raymarching experiments

The visual component includes custom raymarching experiments. Two geometric forms, representing the participants, dynamically merge or separate according to the degree of synchronisation between their breathing patterns.

The shader translates an otherwise invisible relationship between two bodies into a continuously changing visual form.

## Project context

Embodiment was developed as a collaborative experimental VR project combining physical computing, biofeedback, immersive interaction and real-time visualisation.

**Keywords:** Embodied interaction · Biofeedback · Virtual Reality · Physical Computing · Signal Processing · Networked Interaction · Raymarching · Interactive Installation
