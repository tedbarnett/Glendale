Working with the Horse chestnut Tree Package
--------------------------------------------

1. Optimized Textures and Materials
--------------------------------------------
Please note that all tree prefabs share the same materials and textures in order to save texture memory and texture load at runtime.
Usually unity automaticly creates materials and textures for each tree.
I have just deleted all those texture folders except for one, then assigned the materials "My Optimized Bark Metrial" and "My Optimized Leaf Material" both located in the folder "My Materials" to each tree by dragging them from the project tab to the proper slot of each tree in the inspector tab.

Changing any parameter on any tree will unity force to recalculate the textures so the additional folders will be recreated. In this case just delete the new folders and reassign the original materials like described above.

Those materials use the textures you find in the folder "xyz Master_Textures". Please note the special texture settings of those textures: High Aniso Level [9] on the diffuse texture and kaiser-mipmapping.

Next to that this package comes with high resolution textures for bark and leaves [diffuse only] at a resolution of 2048x1024px which usually is not supported by the tree creator.
You will find this texture in the the folder "Horse Chestnut Master_Textures" and it is called "diffuse_highres". i manually created this texture using photoshop and manually assigned it to both "My Materials" --> "My Optimized Bark material" and "My Optimized Leave Material" so it gets used on all trees as they all share the same material.

!!!!!! Make sure that the max size of this texture is set to 2048 !!!!!


2. Changes in Unity 3.5
--------------------------------------------
In unity 3.5 you can not assign any texture manually to the materials created automatically by the treecreator.
For this reason I have created 2 new materials called "My Optimized Bark Material" and "My Optimized Leaf Material" which use the "Hidden/Nature/TreeCreatorBarkOptimized" and "Hidden/Nature/TreeCreatorLeavesOptimized" shader.
Like you can see in the naimng of those shaders you can’t select them in the material setup window. But i copied the shaders into the asset folder, so you can just drag and drop the shader to the material within the project tab.


