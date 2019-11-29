//declare recurrent global variables
const scene = new THREE.Scene();
var camera = new THREE.PerspectiveCamera(45, window.innerWidth / window.innerHeight, 0.1, 1000);
const renderer = new THREE.WebGLRenderer({ antialias: true });
const clock = new THREE.Clock();

//declare global variables
var trackballControl,
controls,
plane; //this will be used to limit the position of the new objects

//var arrayOfPlanes= [];
arrayOfPlanes = new THREE.Object3D();

var raycaster = new THREE.Raycaster(),INTERSECTED;
var mouse = new THREE.Vector2();

function init() {
    renderer.setClearColor(new THREE.Color(0xffffff));
    renderer.setSize(window.innerWidth, window.innerHeight);
    document.body.appendChild(renderer.domElement);

    camera.position.x = -30;
    camera.position.y = 40;
    camera.position.z = 30;

    camera.lookAt(scene.position);

    trackballControl = new THREE.TrackballControls(camera, renderer.domElement);

    window.addEventListener( 'mousemove', onDocumentMouseMove, false );
    window.addEventListener( 'mousedown', onDocumentMouseDown, false );
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

    var size = 50;
    var divisions = 10;

    var gridHelper = new THREE.GridHelper( size, divisions );
    scene.add( gridHelper );

    makePlane(2.5, 2.5);
    makePlane(-2.5, 2.5);
    makePlane(2.5, -2.5);
    makePlane(-2.5, -2.5);
    makePlane(7.5, 7.5);
    makePlane(-7.5, -7.5);
    makePlane(-7.5, 7.5);
    makePlane(7.5, -7.5);
    makePlane(7.5, 2.5);
    makePlane(-7.5, -2.5);
    makePlane(7.5, -2.5);
    makePlane(-7.5, 2.5);
    makePlane(2.5, 7.5);
    makePlane(-2.5, -7.5);
    makePlane(-2.5, 7.5);
    makePlane(2.5, -7.5);


    scene.add(arrayOfPlanes);
}

function makePlane(x, z)
{
    var planeGeometry = new THREE.PlaneBufferGeometry(5, 5);

    var planeMaterial = new THREE.MeshPhongMaterial({
                color: 0x3333ff
            });
    //var planeMaterial = new THREE.MeshPhongMaterial({ color: 0x3333ff });
    plane = new THREE.Mesh(planeGeometry, planeMaterial);

    // rotate and position the plane
    plane.rotation.x = -0.5 * Math.PI;
    plane.position.set(x,0, z);

    // add the plane to the scene
    //scene.add(plane);

    //arrayOfPlanes[i] = plane;
    arrayOfPlanes.add(plane);

    var geometry = new THREE.BoxGeometry( 1, 1, 1 );
    var material = new THREE.MeshBasicMaterial( {color: 0x00ff00} );
    var cube = new THREE.Mesh( geometry, material );
    

}

function onDocumentMouseDown(event) {
    console.log("click");
};

function onDocumentMouseMove(event) {
    console.log("move");
    mouse.x = (event.clientX / window.innerWidth) * 2 - 1;
    mouse.y = -(event.clientY / window.innerHeight) * 2 + 1;
    mouseX = event.clientX - window.innerWidth / 2;
    mouseY = event.clientY - window.innerHeight / 2;
    camera.position.x += (mouseX - camera.position.x) * 0.005;
    camera.position.y += (mouseY - camera.position.y) * 0.005;
    //set up camera position
    camera.lookAt(scene.position);
};

function render() {
    //update raycaster with mouse movement  
    raycaster.setFromCamera(mouse, camera);
    // calculate objects intersecting the picking ray
    var intersects = raycaster.intersectObjects(arrayOfPlanes.children);
  //count and look after all objects in the diamonds group
    if (intersects.length > 0) {
        if (INTERSECTED != intersects[0].object) {
            if (INTERSECTED) INTERSECTED.material.emissive.setHex(INTERSECTED.currentHex);
            INTERSECTED = intersects[0].object;
            INTERSECTED.currentHex = INTERSECTED.material.emissive.getHex();
            //setting up new material on hover
            INTERSECTED.material.emissive.setHex(0xffff66);
        }
    } else {
        if (INTERSECTED) INTERSECTED.material.emissive.setHex(0x3333ff);
        INTERSECTED = null;
    }
}

function animate() {
    trackballControl.update(clock.getDelta());
    renderer.render(scene, camera);
    requestAnimationFrame(animate);
    render();
}


//javascript function to drive your scene
window.onload = function () {
    init();
    createCameraAndLights();
    createGeometry();
    animate();
}