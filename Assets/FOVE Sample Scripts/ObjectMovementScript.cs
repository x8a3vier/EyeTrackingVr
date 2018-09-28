using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using UnityEngine;

public class ObjectMovementScript : MonoBehaviour {

    public GameObject desk;
    public GameObject GreenCube;
    public GameObject YellowSphere;
    public GameObject GreyCapsule;
    public GameObject CyanCylander;
    public GameObject RedCube;
    public GameObject PurpleCube;
    public GameObject BlackSphere;
    public GameObject BrownSphere;
    public GameObject PinkCapsule;
    public GameObject OrangeCylander;

    public Collider c_GreenCube;
    public Collider c_YellowSphere;
    public Collider c_GreyCapsule;
    public Collider c_CyanCylander;
    public Collider c_RedCube;
    public Collider c_PurpleCube;
    public Collider c_BlackSphere;
    public Collider c_BrownSphere;
    public Collider c_PinkCapsule;
    public Collider c_OrangeCylander;

    public GameObject l_GreenCube;
    public GameObject l_YellowSphere;
    public GameObject l_GreyCapsule;
    public GameObject l_CyanCylander;
    public GameObject l_RedCube;
    public GameObject l_PurpleCube;
    public GameObject l_BlackSphere;

    public FoveInterfaceBase fove;
    public int scenenum;
    public Vector3 in1;
    public Vector3 in2 = new Vector3(0, 20, 0);
    public Vector3 in3 = new Vector3(0, 0, 0);
    public Vector3 origion = new Vector3(0, 0, 0);
    Vector3 position1 = new Vector3(0, 20, 0);
    public FoveInterfaceBase foVe;

    public GameObject sceneOBJ;
    public KeyCode SceneChangingButton = KeyCode.S;



    // Use this for initialization
    void Start () {

        scenenum = 0;

        desk.SetActive(true);
        desk.transform.position = position1;

        GreenCube.SetActive(true);
        GreenCube.transform.position = position1;

        YellowSphere.SetActive(true);
        YellowSphere.transform.position = position1;

        GreyCapsule.SetActive(true);
        GreyCapsule.transform.position = position1;

        CyanCylander.SetActive(true);
        CyanCylander.transform.position = position1;

        RedCube.SetActive(true);
        RedCube.transform.position = position1;

        PurpleCube.SetActive(true);
        PurpleCube.transform.position = position1;

        BlackSphere.SetActive(true);
        BlackSphere.transform.position = position1;

        BrownSphere.SetActive(true);
        BrownSphere.transform.position = position1;

        PinkCapsule.SetActive(true);
        PinkCapsule.transform.position = position1;

        OrangeCylander.SetActive(true);
        OrangeCylander.transform.position = position1;

        l_BlackSphere.SetActive(true);
        l_CyanCylander.SetActive(true);
        l_GreenCube.SetActive(true);
        l_GreyCapsule.SetActive(true);
        l_PurpleCube.SetActive(true);
        l_RedCube.SetActive(true);
        l_YellowSphere.SetActive(true);

        //eyeCursorR.SetActive(false);
        //eyeCursorL.SetActive(false);

        sceneOBJ.transform.position = new Vector3(0, 20, 0);
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 in4 = new Vector3(0, 20, 0);
            if (fove.Gazecast(c_GreenCube) == true) { GreenCube.transform.position = in4; }
            if (fove.Gazecast(c_YellowSphere) == true) { YellowSphere.transform.position = in4; }
            if (fove.Gazecast(c_GreyCapsule) == true) { GreyCapsule.transform.position = in4; }
            if (fove.Gazecast(c_CyanCylander) == true) { CyanCylander.transform.position = in4; }
            if (fove.Gazecast(c_RedCube) == true) { RedCube.transform.position = in4; }
            if (fove.Gazecast(c_PurpleCube) == true) { PurpleCube.transform.position = in4; }
            if (fove.Gazecast(c_BlackSphere) == true) { BlackSphere.transform.position = in4; }
            if (fove.Gazecast(c_BrownSphere) == true) { BrownSphere.transform.position = in4; }
            if (fove.Gazecast(c_PinkCapsule) == true) { PinkCapsule.transform.position = in4; }
            if (fove.Gazecast(c_OrangeCylander) == true) { OrangeCylander.transform.position = in4; }
        }

        if (Input.GetKeyDown(SceneChangingButton) == true)
        {
            scenenum++;

            if (scenenum == 1)
            {
                l_BlackSphere.SetActive(false);
                l_CyanCylander.SetActive(false);
                l_GreenCube.SetActive(false);
                l_GreyCapsule.SetActive(false);
                l_PurpleCube.SetActive(false);
                l_RedCube.SetActive(false);
                l_YellowSphere.SetActive(false);

                in1 = new Vector3(-0.49f, 0.461f, -2.146f);
                desk.transform.position = in1;//placing object
                desk.transform.localScale = new Vector3(123, 50, 180);

                in1 = new Vector3(-1.4f, 1.137f, -1.18f);
                GreenCube.transform.position = in1;//placing object
               // l_GreenCube.transform.position = in3;
               // c_GreenCube.transform.position = in3;


                in1 = new Vector3(-0.48f, 1.124f, -1.84f);
                YellowSphere.transform.position = in1;//placing object
               // l_YellowSphere.transform.position = in1;

                GreyCapsule.transform.position = in2;//on standby

                CyanCylander.transform.position = in2;//on standby

                in1 = new Vector3(-0.75f, 1.137f, -0.6f);
                RedCube.transform.position = in1;//placing object

                in1 = new Vector3(-0.31f, 1.137f, -1.17f);
                PurpleCube.transform.position = in1;//placing object

                in1 = new Vector3(0.33f, 1.148f, -1.38f);
                BlackSphere.transform.position = in1;//placing object

                BrownSphere.transform.position = in2;//on standby

                PinkCapsule.transform.position = in2;//on standby

                OrangeCylander.transform.position = in2;//on standby

                sceneOBJ.transform.position = new Vector3(0, 20, 1);
            }

            if (scenenum == 2)
            {
                in1 = new Vector3(-0.49f, 0.505f, -1.88f);
                desk.transform.position = in1;//Placing object
                desk.transform.localScale = new Vector3(136.8375f, 50, 180);

                in1 = new Vector3(0.183f, 1.137f, -1.41f);
                GreenCube.transform.position = in1;

                in1 = new Vector3(-0.785f, 1.13f, -1.275f);
                YellowSphere.transform.position = in1;

                in1 = new Vector3(-2.256f, 1.295f, -1.065f);
                GreyCapsule.transform.position = in1;

                in1 = new Vector3(1.087f, 1.16f, -1.4704f);
                CyanCylander.transform.position = in1;

                in1 = new Vector3(-1.293f, 1.137f, -0.783f);
                RedCube.transform.position = in1;

                in1 = new Vector3(-0.36f, 1.14f, -0.19f);
                PurpleCube.transform.position = in1;

                in1 = new Vector3(0.18f, 1.142f, -0.71f);
                BlackSphere.transform.position = in1;

                in1 = new Vector3(-0.29f, 1.145f, -1.616f);
                BrownSphere.transform.position = in1;

                in1 = new Vector3(0.836f, 1.269f, -0.913f);
                PinkCapsule.transform.position = in1;

                in1 = new Vector3(-1.564f, 1.16f, -1.669f);
                OrangeCylander.transform.position = in1;

                sceneOBJ.transform.position = new Vector3(0, 20, 2);
            }

            if (scenenum == 3)
            {
                in1 = new Vector3(-0.29f, 0.48f, 0.3710f);
                desk.transform.position = in1;
                desk.transform.localScale = new Vector3(123, 50, 284.201f);

                in1 = new Vector3(-0.988f, 1.137f, 2.252f);
                GreenCube.transform.position = in1;

                in1 = new Vector3(-0.432f, 1.15f, 0.83f);
                YellowSphere.transform.position = in1;


                GreyCapsule.transform.position = in2;


                CyanCylander.transform.position = in2;

                in1 = new Vector3(-1.496f, 1.137f, 1.805f);
                RedCube.transform.position = in1;

                in1 = new Vector3(0.043f, 1.137f, 2.337f);
                PurpleCube.transform.position = in1;

                in1 = new Vector3(0.426f, 1.15f, 1.5879f);
                BlackSphere.transform.position = in1;


                BrownSphere.transform.position = in2;


                PinkCapsule.transform.position = in2;


                OrangeCylander.transform.position = in2;

                sceneOBJ.transform.position = new Vector3(0, 20, 3);
            }

            if (scenenum == 4)
            {
                in1 = new Vector3(-0.461f, 0.48f, 1.67f);
                desk.transform.position = in1;
                desk.transform.localScale = new Vector3(132, 50, 209.581f);

                in1 = new Vector3(-1.507f, 1.137f, 2.292911f);
                GreenCube.transform.position = in1;

                in1 = new Vector3(-0.6879999f, 1.133f, 2.024f);
                YellowSphere.transform.position = in1;

                in1 = new Vector3(-1.965f, 1.295f, 2.744911f);
                GreyCapsule.transform.position = in1;

                in1 = new Vector3(1.099f, 1.16f, 2.497501f);
                CyanCylander.transform.position = in1;

                in1 = new Vector3(-0.226f, 1.137f, 2.57f);
                RedCube.transform.position = in1;

                in1 = new Vector3(-0.44f, 1.137f, 3.602f);
                PurpleCube.transform.position = in1;

                in1 = new Vector3(0.124f, 1.133f, 3.004f);
                BlackSphere.transform.position = in1;

                in1 = new Vector3(-1.207f, 1.133f, 2.912f);
                BrownSphere.transform.position = in1;

                in1 = new Vector3(0.836f, 1.269f, 3.055f);
                PinkCapsule.transform.position = in1;

                in1 = new Vector3(0.443f, 1.16f, 2.497501f);
                OrangeCylander.transform.position = in1;

                sceneOBJ.transform.position = new Vector3(0, 20, 4);
            }

            if (scenenum == 5)
            {
                desk.transform.position = in2;

                in1 = new Vector3(-2.024f, 2.162f, -1.225f);
                GreenCube.transform.position = in1;

                in1 = new Vector3(-0.381f, 1.631f, 0.016f);
                YellowSphere.transform.position = in1;

                GreyCapsule.transform.position = in2;

                CyanCylander.transform.position = in2;

                in1 = new Vector3(0.15f, 1.5f, -0.74f);
                RedCube.transform.position = in1;

                in1 = new Vector3(0.83f, 1.854f, -1.19f);
                PurpleCube.transform.position = in1;

                in1 = new Vector3(-0.988f, 1.349f, -1.794f);
                BlackSphere.transform.position = in1;

                BrownSphere.transform.position = in2;

                PinkCapsule.transform.position = in2;

                OrangeCylander.transform.position = in2;

                sceneOBJ.transform.position = new Vector3(0, 20, 5);
            }

            if (scenenum == 6)
            {
                desk.transform.position = in2;

                in1 = new Vector3(-2.349f, 2.162f, -2.66f);
                GreenCube.transform.position = in1;

                in1 = new Vector3(-1.285f, 1.28f, -2.04f);
                YellowSphere.transform.position = in1;

                in1 = new Vector3(0.373f, 1.492208f, -2.082f);
                GreyCapsule.transform.position = in1;

                in1 = new Vector3(-2.126f, 1.991f, -1.566f);
                CyanCylander.transform.position = in1;

                in1 = new Vector3(0.16f, 1.495f, -0.598f);
                RedCube.transform.position = in1;

                in1 = new Vector3(-0.56399992f, 1.854f, -2.082f);
                PurpleCube.transform.position = in1;

                in1 = new Vector3(-1.892f, 1.349f, -2.311f);
                BlackSphere.transform.position = in1;

                in1 = new Vector3(-1.0019999f, 1.631f, -2.221f);
                BrownSphere.transform.position = in1;

                in1 = new Vector3(1.31f, 1.492208f, -1.83f);
                PinkCapsule.transform.position = in1;

                in1 = new Vector3(0.84f, 1.991f, -1.58f);
                OrangeCylander.transform.position = in1;

                sceneOBJ.transform.position = new Vector3(0, 20, 6);
            }

            if (scenenum == 7)
            {
                desk.transform.position = in2;

                in1 = new Vector3(1.414f, 2.162f, 1.493f);
                GreenCube.transform.position = in1;

                in1 = new Vector3(-0.09900001f, 1.631f, 2.157f);
                YellowSphere.transform.position = in1;

                GreyCapsule.transform.position = in2;

                CyanCylander.transform.position = in2;

                in1 = new Vector3(-2.065f, 1.495f, 1.822f);
                RedCube.transform.position = in1;

                in1 = new Vector3(-0.616f, 1.854f, 0.791f);
                PurpleCube.transform.position = in1;

                in1 = new Vector3(-0.897f, 1.349f, 3.323f);
                BlackSphere.transform.position = in1;

                BrownSphere.transform.position = in2;

                PinkCapsule.transform.position = in2;

                OrangeCylander.transform.position = in2;

                sceneOBJ.transform.position = new Vector3(0, 20, 7);
            }

            if (scenenum == 8)
            {
                desk.transform.position = in2;

                in1 = new Vector3(-1.77f, 0.971f, -0.267f);
                GreenCube.transform.position = in1;

                in1 = new Vector3(0.436f, 1.808f, -1.06f);
                YellowSphere.transform.position = in1;

                in1 = new Vector3(0.73f, 1.373f, 1.049f);
                GreyCapsule.transform.position = in1;

                in1 = new Vector3(-1.78f, 1.871792f, -0.871792f);
                CyanCylander.transform.position = in1;

                in1 = new Vector3(-2.812f, 1.376f, 1.729f);
                RedCube.transform.position = in1;

                in1 = new Vector3(-0.274f, 1.734792f, 0.079f);
                PurpleCube.transform.position = in1;

                in1 = new Vector3(-0.995f, 1.944792f, 1.2099998f);
                BlackSphere.transform.position = in1;

                in1 = new Vector3(-0.712f, 1.511792f, 0.218f);
                BrownSphere.transform.position = in1;

                in1 = new Vector3(1.47f, 1.373f, 1.541f);
                PinkCapsule.transform.position = in1;

                in1 = new Vector3(0.117f, 1.239f, 1.7f);
                OrangeCylander.transform.position = in1;

                sceneOBJ.transform.position = new Vector3(0, 20, 8);
            }

            if (scenenum > 8)//reset the scene to default 1
            {
                /*scenenum = 1;
                in1 = new Vector3(-0.49f, 0.461f, -2.146f);
                desk.transform.position = in1;//placing object

                in1 = new Vector3(-1.4f, 1.137f, -1.18f);
                GreenCube.transform.position = in1;//placing object

                in1 = new Vector3(-0.48f, 1.124f, -1.84f);
                YellowSphere.transform.position = in1;//placing object

                GreyCapsule.transform.position = in2;//on standby

                CyanCylander.transform.position = in2;//on standby

                in1 = new Vector3(-0.75f, 1.137f, -0.6f);
                RedCube.transform.position = in1;//placing object

                in1 = new Vector3(-0.31f, 1.137f, -1.17f);
                PurpleCube.transform.position = in1;//placing object

                in1 = new Vector3(0.33f, 1.148f, -1.38f);
                BlackSphere.transform.position = in1;//placing object

                BrownSphere.transform.position = in2;//on standby

                PinkCapsule.transform.position = in2;//on standby

                OrangeCylander.transform.position = in2;//on standby

                sceneOBJ.transform.position = new Vector3(0, 20, 8);*/
                Application.Quit();
            }
        }
    }
}
