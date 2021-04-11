# Unity Character Movement

1- Put "direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"))" in Update method then check it in the FixedUpdate method.

2- Use velocity to move right and left, and use force to make the jump.

3- To make the jump, you have to check if the character is on the ground by creating an empty object and attach it to the character, then check if the empty object is colliding with the ground.

4- Of course you have to define what is ground, by making a new layer and put all objects that are supposed to be ground in it and choose this layer as ground.

5- Check freeze rotation because if you don't, you will lose control of your character, trust me (Rigidbody2D -> constrains -> Freeze Rotation -> Z).

6- Create physics material with zero friction then, assign it to the character to avoid sticking to the wall.

7- Don't use Box Collider for the character use any collider with a rounded shape.
