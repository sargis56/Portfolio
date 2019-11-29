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
    renderer.setClearColor(new THREE.Color(0xffffff));
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
    var planeGeometry = new THREE.PlaneBufferGeometry(500, 500);
    var planeMaterial = new THREE.MeshBasicMaterial({ color: 0x3333ff });
    plane = new THREE.Mesh(planeGeometry, planeMaterial);

    // rotate and position the plane
    plane.rotation.x = -0.5 * Math.PI;
    plane.position.set(15, -50, 0);

    // add the plane to the scene
    scene.add(plane);
    
    makeWheel(35, 30, 5, 0, 0, 0 );

    makeWheel(50, 40, 30, 0, 0, -100 );

    makeWheel(15, 10, 1, 0, 0, -50 );

}

function makeWheel(outerRadius, innerRadius, axleRadius, transX, transY, transZ) {
    var x = 0, y = 0;
    var shape = new THREE.Shape();

   shape.moveTo( x, y );
   outerRadius
   //shape.arc(0, 0, 35, 0, 2 * Math.PI);
   shape.arc(0, 0, outerRadius, 0, 2 * Math.PI);
   
    var hole = new THREE.Path();
    
    //hole.absellipse( 0 + transX, 0 + transY, 30, 30, 0, Math.PI * 2, true );
    hole.absellipse( 0, 0 , innerRadius, innerRadius, 0, Math.PI * 2, true );
    shape.holes.push( hole );

    var extrudeSettings = {
        steps: 2,
        depth: 16,
        bevelEnabled: true,
        bevelThickness: 2.5,
        bevelSize: 2.5,
        bevelSegments: 1
    };
    
    //0x9e5c5e
    var geometry = new THREE.ExtrudeGeometry( shape, extrudeSettings );
    var material = new THREE.MeshStandardMaterial( { color: 0x996633 } );
    var mesh = new THREE.Mesh( geometry, material ) ;
    //mesh.rotation.x = 9;
    //scene.add( mesh );

    //var cylGeometry = new THREE.CylinderGeometry( 4, 4, 60, 32 );
    var cylGeometry = new THREE.CylinderGeometry( 4, 4, outerRadius * 2, 32 );
    var cylMaterial = new THREE.MeshStandardMaterial( {color: 0xff9900} );
    var cylinder = new THREE.Mesh( cylGeometry, cylMaterial );
    cylinder.translateZ(8);
    //scene.add( cylinder );

    var cylinder2 = cylinder.clone();
    cylinder2.rotation.z = 0.5;
    //scene.add( cylinder2 );

    var cylinder3 = cylinder.clone();
    cylinder3.rotation.z = 1;
    //scene.add( cylinder3 );

    var cylinder4 = cylinder.clone();
    cylinder4.rotation.z = 1.5;
    //scene.add( cylinder4 );

    var cylinder5 = cylinder.clone();
    cylinder5.rotation.z = 2;
    //scene.add( cylinder5 );

    var cylinder6 = cylinder.clone();
    cylinder6.rotation.z = 2.5;
    //scene.add( cylinder6 );

    //var cylAxleGeometry = new THREE.CylinderGeometry( 5, 5, 12, 12 );
    var cylAxleGeometry = new THREE.CylinderGeometry( axleRadius, axleRadius, 12, 12 );
    var cylAxleMaterial = new THREE.MeshStandardMaterial( {color: 0x996633} );
    var cylAxleinder = new THREE.Mesh( cylAxleGeometry, cylAxleMaterial );
    cylAxleinder.translateZ(8);
    cylAxleinder.rotation.x = 1.55;
    //scene.add( cylAxleinder );

    wheelGroup = new THREE.Object3D();
    wheelGroup.add( mesh );
    wheelGroup.add( cylinder );
    wheelGroup.add( cylinder2 );
    wheelGroup.add( cylinder3 );
    wheelGroup.add( cylinder4 );
    wheelGroup.add( cylinder5 );
    wheelGroup.add( cylinder6 );
    wheelGroup.add( cylAxleinder );

    wheelGroup.translateZ(transZ);
    wheelGroup.translateX(transX);
    wheelGroup.translateY(transY);

    scene.add(wheelGroup);

}

function animate() {
    trackballControl.update(clock.getDelta());
    renderer.render(scene, camera);
    requestAnimationFrame(animate);
}


//javascript function to drive your scene
window.onload = function () {
    init();
    createCameraAndLights();
    createGeometry();
    animate();
}