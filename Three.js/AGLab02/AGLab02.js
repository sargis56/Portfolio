//declare recurrent global variables
const scene = new THREE.Scene();
var camera = new THREE.PerspectiveCamera(45, window.innerWidth / window.innerHeight, 0.1, 1000);
const renderer = new THREE.WebGLRenderer({ antialias: true });
const clock = new THREE.Clock();

//declare global variables
var trackballControl,
controls,
plane; //this will be used to limit the position of the new objects

function init() {
    renderer.setClearColor(new THREE.Color(0xaaffaa));
    renderer.setSize(window.innerWidth, window.innerHeight);
    document.body.appendChild(renderer.domElement);

    camera.position.x = -30;
    camera.position.y = 40;
    camera.position.z = 30;

    camera.lookAt(scene.position);

    trackballControl = new THREE.TrackballControls(camera, renderer.domElement);

    let geom = new THREE.BoxGeometry(2, 2, 2);
    let mat = new THREE.MeshStandardMaterial({ color: 0xaaaaff });
    let mesh = new THREE.Mesh(geom, mat);
    mesh.position.y = 1;
    scene.add(mesh);
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
}

function createGeometry() {
    // create the ground plane
    var planeGeometry = new THREE.PlaneBufferGeometry(60, 20);
    var planeMaterial = new THREE.MeshBasicMaterial({ color: 0xcccccc });
    plane = new THREE.Mesh(planeGeometry, planeMaterial);

    // rotate and position the plane
    plane.rotation.x = -0.5 * Math.PI;
    plane.position.set(15, 0, 0);

    // add the plane to the scene
    scene.add(plane);
}

function animate() {
    trackballControl.update(clock.getDelta());
    renderer.render(scene, camera);
    requestAnimationFrame(animate);
}

function showVariablesFunc(size, shape, color, posx, posy, posz) {
    console.log("Size: " + size + "\nShape: " + shape + "\nColor: " + color + "\nX: " + posx + "\nY: " + posy + "\nZ: " + posz);
}

function addGeoFunc(size, shape, col, posx, posy, posz) {

    if (shape == "cube") 
    {
        let boxGeometry = new THREE.BoxGeometry(size, size, size);
        let boxMaterial = new THREE.MeshBasicMaterial({ color: col });
        let box = new THREE.Mesh(boxGeometry, boxMaterial);
        scene.add(box);

        box.translateY(posy);
        box.translateX(posx);
        box.translateZ(posz);
    }
    else
    {
        let sphereGeometry = new THREE.SphereGeometry(size, 32, 32);
        let sphereMaterial = new THREE.MeshLambertMaterial({ color: col });
        let sphere = new THREE.Mesh(sphereGeometry, sphereMaterial);
        scene.add(sphere);

        sphere.translateY(posy);
        sphere.translateX(posx);
        sphere.translateZ(posz);
    }

}

var geoPlacer = function() {
    this.size = 2;
    this.shapes = 'cube';
    this.color = "#ffae23";
    this.posx = 0;
    this.posy = 0;
    this.posz = 0;
    this.addGeo = function() {new addGeoFunc(this.size, this.shapes, this.color, this.posx, this.posy, this.posz)};
    this.showVariables = function() {new showVariablesFunc(this.size, this.shapes, this.color, this.posx, this.posy, this.posz)};
};

function createGui() {
    var gPlacerGUI = new geoPlacer();
    var gui = new dat.GUI();
    gui.add(gPlacerGUI, 'showVariables');
    gui.add(gPlacerGUI, 'size', 2, 6, 1);
    gui.add(gPlacerGUI, 'shapes', [ 'sphere', 'cube' ] )
    gui.addColor(gPlacerGUI, 'color');
    gui.add(gPlacerGUI, 'addGeo');
    gui.add(gPlacerGUI, 'posx', 0, plane.geometry.parameters.width);
    gui.add(gPlacerGUI, 'posy', 0, 25);
    gui.add(gPlacerGUI, 'posz', 0, 15);
}

//javascript function to drive your scene
window.onload = function () {
    init();
    createCameraAndLights();
    createGeometry();
    animate();
    createGui();
}