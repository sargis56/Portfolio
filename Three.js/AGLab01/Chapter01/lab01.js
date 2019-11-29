/// <reference path="libs/three.min.js" />
/// <reference path="libs/trackballcontrols.js" />
//name: Narendra
//date: January 11, 2019
//file: lab01.js

//recurrent const
const scene = new THREE.Scene();
const camera = new THREE.PerspectiveCamera( 45, window.innerWidth / window.innerHeight, 0.1, 1000);
const renderer = new THREE.WebGLRenderer();
const clock = new THREE.Clock();

//global variables
var trackballControls;

//function definitions
function init() {
    //the renderer
    renderer.setClearColor(new THREE.Color(0X0095DE));
    renderer.setSize(window.innerWidth, window.innerHeight);
    document.body.appendChild(renderer.domElement);

    trackballControls =  new THREE.TrackballControls( camera, renderer.domElement)
}

function setupCameraAndLight() {
    camera.position.x = -30;
    camera.position.y = 40;
    camera.position.z = 30;
    camera.lookAt(scene.position);

    let ambient = new THREE.AmbientLight(0x353535);
    scene.add(ambient);
}

function createGeometry() {
    let planeGeometry = new THREE.PlaneGeometry(60, 20, 1, 1);
    let planeMaterial = new THREE.MeshLambertMaterial({ color: 0X4aad78 });
    let plane = new THREE.Mesh(planeGeometry, planeMaterial);
    plane.rotation.x = -0.5 * Math.PI;
    plane.position.x = 15;
    plane.position.y = 0;
    plane.position.z = 0;

    let sphereGeometry = new THREE.SphereGeometry(5, 32, 32);
    let sphereMaterial = new THREE.MeshLambertMaterial({ color: 0xffff00 });
    let sphere = new THREE.Mesh(sphereGeometry, sphereMaterial);
    scene.add(sphere);

    let boxGeometry = new THREE.BoxGeometry(5, 5, 5);
    let boxMaterial = new THREE.MeshBasicMaterial({ color: 0x3FFF00 });
    let box = new THREE.Mesh(boxGeometry, boxMaterial);
    scene.add(box);

    var cyGeometry = new THREE.CylinderGeometry(5, 5, 5);
    var cyMaterial = new THREE.MeshBasicMaterial({ color: 0xFF2D00 });
    var cylinder = new THREE.Mesh(cyGeometry, cyMaterial);
    scene.add(cylinder);

    let axesHelper = new THREE.AxesHelper(100);

    box.translateY(5);
    box.translateX(20);

    cylinder.translateY(5);
    cylinder.translateX(40);

    sphere.translateY(5);

    scene.add(axesHelper);
    scene.add(plane);
}

function render() {
    //update the controlls
    trackballControls.update(clock.getDelta());
    renderer.render(scene, camera);

    //to call itself
    requestAnimationFrame(render);
}
//launch
window.onload = () => {

    init();
    setupCameraAndLight();
    createGeometry();
    render();

}
