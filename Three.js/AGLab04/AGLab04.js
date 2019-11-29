//declare recurrent global variables
const scene = new THREE.Scene();
var camera = new THREE.PerspectiveCamera(45, window.innerWidth / window.innerHeight, 0.1, 1000);
const renderer = new THREE.WebGLRenderer({ antialias: true });
const clock = new THREE.Clock();

//Meteral: Phong
//Geo: Cone

//declare global variables
var trackballControl,
controls,
plane; //this will be used to limit the position of the new objects
var AmbientLightBolGol;
var ambientLight;
var spotLight;
var light2;
var rectLight;
var directionalLight;
var light3;

var coneMaterial;
var coneGeometry;

var texture;

function init() {
    renderer.setClearColor(new THREE.Color(0x4bff00));
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
    texture = new THREE.TextureLoader().load( "textures/water.jpg" );
    texture2 = new THREE.TextureLoader().load( "textures/grass.jpg" );
    texture3 = new THREE.TextureLoader().load( "textures/dump.jpg" );

    // create the ground plane
    var planeGeometry = new THREE.PlaneBufferGeometry(60, 20);
    var planeMaterial = new THREE.MeshLambertMaterial({ color: 0x3333ff });
    plane = new THREE.Mesh(planeGeometry, planeMaterial);

    // rotate and position the plane
    plane.rotation.x = -0.5 * Math.PI;
    plane.position.set(15, 0, 0);

        //let coneGeometry = new THREE.CylinderGeometry(0, 10, 25, 25, 25, true);
        coneGeometry = new THREE.ConeGeometry( 10, 20, 32 );
        coneMaterial = new THREE.MeshPhongMaterial(
            {
            color: 0x66aa66, specular: 0xff, emissive: 0xff004b, map: texture, envMap: texture, displacementMap: texture2, reflectivity: 0, transparent: true, opacity: 1
            });
        let cone = new THREE.Mesh(coneGeometry, coneMaterial);
        scene.add(cone);
        cone.castShadow = true;
        cone.translateY(25);
        cone.translateX(5);
        cone.receiveShadow = true;

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

var guiGeoMod = function() {
    //1
    this.GeoWireframe = false;
    //2
    this.GeoShininess = 2;
    //3
    this.GeoSpecular = 0xff;
    //4
    this.GeoEmissive = 0xff004b;
    //5
    this.GeoEmissiveIntensity = 0;
    //6
    this.GeoReflectivity = 0;
    //7
    this.GeoDisplacementBias = 0;
    //8
    this.GeoSide = 0;
    //9
    this.GeoOpacity = 0;
    //10
    this.GeoTransparent = true;
} 
function createGui() {
    var geoModGUI = new guiGeoMod();
    var gui = new dat.GUI();

    //1
    gui.add(geoModGUI, 'GeoWireframe')
        .name('1. Wireframe')
        .onChange((e)=>{
        coneMaterial.wireframe = e;
    });
    //2
    gui.add(geoModGUI, 'GeoShininess', 0, 100)
        .name('2. Shininess')
        .onChange((e)=>{
        coneMaterial.shininess = e;
    });
    //3
    gui.addColor(geoModGUI, 'GeoSpecular')
        .name('3. Specular')
        .onChange((c) => {
        coneMaterial.specular = new THREE.Color(c);
    }); 
    //4
    gui.addColor(geoModGUI, 'GeoEmissive')
        .name('4. Emissive')
        .onChange((c) => {
        coneMaterial.emissive = new THREE.Color(c);
    });
    //5
    gui.add(geoModGUI, 'GeoEmissiveIntensity', 0, 1)
        .name('5. Emissive Intensity')
        .onChange((e)=>{
        coneMaterial.emissiveIntensity = e;
    });
    //6
    gui.add(geoModGUI, 'GeoReflectivity', 0, 1)
        .name('6. Reflectivity')
        .onChange((e)=>{
        coneMaterial.reflectivity = e;
    });
    //7
    gui.add(geoModGUI, 'GeoDisplacementBias', 0, 1)
        .name('7. Displacement Bias')
        .onChange((e)=>{
        coneMaterial.displacementBias = e;
    });
    //8
    gui.add(geoModGUI, 'GeoSide', 0, 1)
        .name('8. Side') 
        .onChange((e)=>{
        coneMaterial.side = e;
    });
    //9
    gui.add(geoModGUI, 'GeoOpacity', 0, 1)
        .name('9. Opacity') 
        .onChange((e)=>{
        coneMaterial.opacity = e;
    });
    //10
    gui.add(geoModGUI, 'GeoTransparent')
        .name('10. Transparent')
        .onChange((e)=>{
        coneMaterial.transparent = e;
    });
} 

//javascript function to drive your scene
window.onload = function () {
    init();
    createCameraAndLights();
    createGeometry();
    animate();
    createGui();
}