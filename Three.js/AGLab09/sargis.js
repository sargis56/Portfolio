/// <reference path="../libs/three.min.js" />
/// <reference path="../libs/dat.gui.min.js" />
/// <reference path="../libs/orbitcontrols.js" />

//author: Narendra Pershad Feb 8, 2019
//filename: 09-lab-base.js
//purpose: a useful base for threejs applications

const renderer = new THREE.WebGLRenderer({ antialias: true });
const scene = new THREE.Scene();
const camera = new THREE.PerspectiveCamera(50, window.innerWidth / window.innerHeight, 1.0, 1000);
const clock = new THREE.Clock();

const __shader1 = Shaders.BasicShader1;
const __shader2 = Shaders.BasicShader2;
const __shader3 = Shaders.BasicShader3;
const __shader4 = Shaders.BasicShader4;

var orbitControls, controls,
    speed = 0.01,
    toRotate = true;

function init() {

    renderer.setPixelRatio(window.devicePixelRatio);
    renderer.setSize(window.innerWidth, window.innerHeight);
    renderer.setClearColor(0x004400);
    renderer.shadowMap.enabled = true;

    document.body.appendChild(renderer.domElement);
    orbitControls = new THREE.OrbitControls(camera, renderer.domElement);

}

function setupCameraAndLight() {
    camera.position.set(-30, 10, 30);
    camera.lookAt(scene.position);

    scene.add(new THREE.AmbientLight(0x666666));
    scene.position.set(0, -10, 0);

    let directionalLight = new THREE.DirectionalLight(0xeeeeee);
    directionalLight.position.set(20, 60, 10);
    directionalLight.castShadow = true;
    directionalLight.target = scene;
    directionalLight.shadow.camera.near = 0.1;
    directionalLight.shadow.camera.far = 200;
    directionalLight.shadow.camera.left = -50;
    directionalLight.shadow.camera.right = 50;
    directionalLight.shadow.camera.top = 50;
    directionalLight.shadow.camera.bottom = -50;
    directionalLight.shadow.mapSize.width = 2048;
    directionalLight.shadow.mapSize.height = 2048;
    scene.add(directionalLight);

    let hemiSphereLight = new THREE.HemisphereLight(0x7777cc, 0x00ff00, 0.6);//skycolor, groundcolor, intensity  
    hemiSphereLight.position.set(0, 100, 0);
    scene.add(hemiSphereLight);
}

function createGeometry() {

    scene.add(new THREE.AxesHelper(100));
    let plane = new THREE.Mesh(
        new THREE.PlaneGeometry(40, 60),
        new THREE.MeshLambertMaterial({ color: 0xeeeeee })
    );
    plane.receiveShadow = true;
    plane.rotation.x = -Math.PI * 0.5;
    scene.add(plane);

    //__shader.uniforms.texture.value = new THREE.TextureLoader().load('https://i.imgur.com/f8MBbej.jpg');


    let material1 = new THREE.ShaderMaterial(
    	{
    		uniforms: __shader1.uniforms,
    		vertexShader: __shader1.vertexShader,
    		fragmentShader: __shader1.fragmentShader
    	});

    let mesh1 = new THREE.Mesh(
        new THREE.BoxGeometry(10, 10, 10),
        material1
    );

    mesh1.position.set(0, 10, -25);
    mesh1.rotation.set(Math.PI * 0.6, 0, Math.PI * 0.3);
    mesh1.castShadow = true;
    scene.add(mesh1);

    let material2 = new THREE.ShaderMaterial(
    	{
    		uniforms: __shader2.uniforms,
    		vertexShader: __shader2.vertexShader,
    		fragmentShader: __shader2.fragmentShader
    	});

    let mesh2 = new THREE.Mesh(
        new THREE.BoxGeometry(10, 10, 10),
        material2
    );

    mesh2.position.set(25, 10, 0);
    mesh2.rotation.set(Math.PI * 0.6, 0, Math.PI * 0.3);
    mesh2.castShadow = true;
    scene.add(mesh2);

    let material3 = new THREE.ShaderMaterial(
    	{
    		uniforms: __shader3.uniforms,
    		vertexShader: __shader3.vertexShader,
    		fragmentShader: __shader3.fragmentShader
    	});

    let mesh3 = new THREE.Mesh(
        new THREE.BoxGeometry(10, 10, 10),
        material3
    );

    mesh3.position.set(-25, 10, 0);
    mesh3.rotation.set(Math.PI * 0.6, 0, Math.PI * 0.3);
    mesh3.castShadow = true;
    scene.add(mesh3);


    let material4 = new THREE.ShaderMaterial(
    	{
    		uniforms: __shader4.uniforms,
    		vertexShader: __shader4.vertexShader,
            fragmentShader: __shader4.fragmentShader
        });

    let mesh4 = new THREE.Mesh(
        new THREE.BoxGeometry(10, 10, 10),
        material4
    );

    mesh4.position.set(0, 10, 25);
    mesh4.rotation.set(Math.PI * 0.6, 0, Math.PI * 0.3);
    mesh4.castShadow = true;
    scene.add(mesh4);

}

function setupDatGui() {

    controls = new function() {

        this.rotate = toRotate;

    }

    let gui = new dat.GUI();
    gui.add(controls, 'rotate').onChange((e) => toRotate = e);


}

function render() {

    orbitControls.update();
    //if (toRotate)
    //    scene.rotation.y += speed;//rotates the scene  
    __shader3.uniforms.time.value = clock.getElapsedTime();
    __shader4.uniforms.time.value = clock.getElapsedTime();
    renderer.render(scene, camera);
    requestAnimationFrame(render);
}

window.onload = () => {

    init();
    setupCameraAndLight();
    createGeometry();
    setupDatGui();
    render();

}
