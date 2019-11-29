//declare recurrent global variables
const scene = new THREE.Scene();
var camera = new THREE.PerspectiveCamera(45, window.innerWidth / window.innerHeight, 0.1, 1000);
const renderer = new THREE.WebGLRenderer({ antialias: true });
const clock = new THREE.Clock();

//declare global variables
var trackballControl,
controls,
plane; //this will be used to limit the position of the new objects
var AmbientLightBolGol = true;
var ambientLight;
var spotLight;
var light2;
var rectLight;
var directionalLight;
var light3;

function init() {
    renderer.setClearColor(new THREE.Color(0x000000));
    renderer.setSize(window.innerWidth, window.innerHeight);
    document.body.appendChild(renderer.domElement);

    camera.position.x = -30;
    camera.position.y = 40;
    camera.position.z = 30;

    camera.lookAt(scene.position);

    trackballControl = new THREE.TrackballControls(camera, renderer.domElement);

}

function createCameraAndLights() {
    camera.position.x = 120;
    camera.position.y = 60;
    camera.position.z = 80;
    camera.lookAt(scene.position);

    // add subtle ambient lighting
    var ambientLight = new THREE.AmbientLight(0x292929);
    scene.add(ambientLight);

    var directionalLight = new THREE.DirectionalLight(0xffffff, 0.7);
    directionalLight.position.set(-20, 40, 60);
    scene.add(directionalLight);

    let axesHelper = new THREE.AxesHelper(100);
    scene.add(axesHelper);
}

function createGeometry() {

    // create the ground plane
    var planeGeometry = new THREE.PlaneBufferGeometry(60, 20);
    var planeMaterial = new THREE.MeshLambertMaterial({ color: 0x3333ff });
    plane = new THREE.Mesh(planeGeometry, planeMaterial);

    // rotate and position the plane
    plane.rotation.x = -0.5 * Math.PI;
    plane.position.set(15, 0, 0);

        let boxGeometry = new THREE.BoxGeometry(5, 5, 5);
        let boxMaterial = new THREE.MeshLambertMaterial({ color: 0x3333ff });
        let box = new THREE.Mesh(boxGeometry, boxMaterial);
        scene.add(box);

        box.translateY(5);
        box.translateX(25);
        box.castShadow = true;
        box.receiveShadow = true;

        let sphereGeometry = new THREE.SphereGeometry(5, 32, 32);
        let sphereMaterial = new THREE.MeshPhongMaterial(
            {
            color: 0x66aa66, specular: 0x0000ff
            });
        let sphere = new THREE.Mesh(sphereGeometry, sphereMaterial);
        scene.add(sphere);
        sphere.castShadow = true;
        sphere.translateY(5);
        sphere.translateX(5);
        sphere.receiveShadow = true;

        //lights
        ambientLight = new THREE.AmbientLight( 0x404040 );
        ambientLight.castShadow = true;
        
        scene.add( ambientLight );
        ambientLight.translateY(25);
        ambientLight.translateX(5);

        spotLight = new THREE.SpotLight( 0xffffff );
        spotLight.position.set( 100, 1000, 100 );

        spotLight.castShadow = true;

        spotLight.shadow.mapSize.width = 1024;
        spotLight.shadow.mapSize.height = 1024;

        spotLight.shadow.camera.near = 500;
        spotLight.shadow.camera.far = 4000;
        spotLight.shadow.camera.fov = 30;
        scene.add( spotLight );
        spotLight.translateY(25);
        spotLight.translateX(5);

        light2 = new THREE.PointLight( 0xff0000, 1, 100 );
        light2.position.set( 50, 50, 50 );
        scene.add( light2 );
        light2.castShadow = true;

        directionalLight = new THREE.DirectionalLight( 0xffffff, 0.5 );
        scene.add( directionalLight );
        directionalLight.castShadow = true;

        var rectWidth = 10;
        var rectHeight = 10;
        var rectIntensity = 1;
        rectLight = new THREE.RectAreaLight( 0xffffff, rectIntensity,  rectWidth, rectHeight );
        rectLight.position.set( 5, 5, 0 );
        rectLight.lookAt( 0, 0, 0 );
        scene.add( rectLight )
        rectLight.translateY(25);
        rectLight.translateX(5);

        rectLightHelper = new THREE.RectAreaLightHelper( rectLight );
        rectLight.add( rectLightHelper );

        light3 = new THREE.HemisphereLight( 0xffffbb, 0x080820, 1 );
        scene.add( light3 );
        light3.translateY(25);
        light3.translateX(5);

    // add the plane to the scene
    scene.add(plane);
    plane.castShadow = true;
    plane.receiveShadow = true;
}

function animate() {
    trackballControl.update(clock.getDelta());
    renderer.render(scene, camera);
    //renderer.shadowMap.enabled = true;
    requestAnimationFrame(animate);
}


var guiLightPlacer = function() {
    this.AmbientLightBol = true;
    this.ambientColor = "#ffae23";

    this.SpotLightBol = true;
    this.spotLightColor = "#ffae23";
    
    this.light2Bol = true;
    this.light2Color = "#ffae23";

        this.directionalLightBol = true;
    this.directionalLightColor = "#ffae23";

        this.rectLightLightBol = true;
    this.rectLightLightColor = "#ffae23";

        this.light3Bol = true;
    this.light3Color = "#ffae23";
};

function createGui() {
    var lPlacerGUI = new guiLightPlacer();
    var gui = new dat.GUI();
    gui.add(lPlacerGUI, 'AmbientLightBol').onChange((e)=>{
        ambientLight.intensity = e;
    });
    gui.addColor(lPlacerGUI, 'ambientColor')
        .name('Ambient Color')
        .onChange((c) => {
        ambientLight.color = new THREE.Color(c);
        }); 

    gui.add(lPlacerGUI, 'SpotLightBol').onChange((e)=>{
        spotLight.intensity = e;
    });
    gui.addColor(lPlacerGUI, 'spotLightColor')
        .name('Spot Color')
        .onChange((c) => {
        spotLight.color = new THREE.Color(c);
        }); 

     gui.add(lPlacerGUI, 'light2Bol').onChange((e)=>{
        light2.intensity = e;
    });
    gui.addColor(lPlacerGUI, 'light2Color')
        .name('Point Light')
        .onChange((c) => {
        light2.color = new THREE.Color(c);
        }); 

    gui.add(lPlacerGUI, 'directionalLightBol').onChange((e)=>{
        directionalLight.intensity = e;
    });
    gui.addColor(lPlacerGUI, 'directionalLightColor')
        .name('Directional Light')
        .onChange((c) => {
        directionalLight.color = new THREE.Color(c);
        }); 

            gui.add(lPlacerGUI, 'rectLightLightBol').onChange((e)=>{
        rectLight.intensity = e;
    });
    gui.addColor(lPlacerGUI, 'rectLightLightColor')
        .name('Rect Light')
        .onChange((c) => {
        rectLight.color = new THREE.Color(c);
        }); 

     gui.add(lPlacerGUI, 'light3Bol').onChange((e)=>{
        light3.intensity = e;
    });
    gui.addColor(lPlacerGUI, 'light3Color')
        .name('Hemi Light')
        .onChange((c) => {
        light3.color = new THREE.Color(c);
        }); 
}

/*
gui.addColor(controls, 'ambientColor')
 .name('Ambient Color')
 .onChange((c) => {
 ambientLight.color = new THREE.Color(c);
}); 
*/

//javascript function to drive your scene
window.onload = function () {
    init();
    createCameraAndLights();
    createGeometry();
    animate();
    createGui();
}