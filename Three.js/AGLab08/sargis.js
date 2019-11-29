//declare recurrent global variables
var scene = new THREE.Scene();
var skyScene = new THREE.Scene();
var camera = new THREE.PerspectiveCamera(45, window.innerWidth / window.innerHeight, 0.1, 1000);
const renderer = new THREE.WebGLRenderer({ antialias: true });
const clock = new THREE.Clock();
var composer = new THREE.EffectComposer(renderer);

//declare global variables
var trackballControl,
controls,
plane; //this will be used to limit the position of the new objects

var effectFilm;
var sepiaShader;

function init() {
    renderer.setClearColor(new THREE.Color(0xffffff));
    renderer.setSize(window.innerWidth, window.innerHeight);
    document.body.appendChild(renderer.domElement);

    camera.position.x = -30;
    camera.position.y = 40;
    camera.position.z = 30;

    camera.lookAt(scene.position);

    trackballControl = new THREE.TrackballControls(camera, renderer.domElement);

    
    var r = "textures/cube/pisa/";
    var urls = [
        r + "px.png", r + "nx.png",
        r + "py.png", r + "ny.png",
        r + "pz.png", r + "nz.png"
    ];
    textureCube = new THREE.CubeTextureLoader().load( urls );
    //scene = new THREE.Scene();
    scene.background = textureCube;

}

function createCameraAndLights() {
    camera.position.x = -30;
    camera.position.y = 40;
    camera.position.z = 30;
    camera.lookAt(scene.position);

    // add subtle ambient lighting
    var ambientLight = new THREE.AmbientLight(0x292929);
    scene.add(ambientLight);

    var directionalLight = new THREE.DirectionalLight(0xffffff, 0.7);
    directionalLight.position.set(-20, 40, 60);
    scene.add(directionalLight);

    let axesHelper = new THREE.AxesHelper(100);
    scene.add(axesHelper);

    var loader = new THREE.AMFLoader();
		loader.load( './models/amf/rook.amf', function ( amfobject ) {
        scene.add( amfobject );
        amfobject.rotation.x = -Math.PI / 2;
		animate();
    } );

    
    var renderPass = new THREE.RenderPass(scene, camera);
    effectFilm = new THREE.FilmPass(0.8, 0.325, 256, false);
    //effectFilm.renderToScreen = true;
  
    sepiaShader = new THREE.ShaderPass(THREE.SepiaShader);
    sepiaShader.renderToScreen = true;

    //var composer = new THREE.EffectComposer(renderer);
    composer.addPass(renderPass);
    composer.addPass(effectFilm);
    composer.addPass(sepiaShader);
    
}

function createGeometry() {
    // create the ground plane
    var planeGeometry = new THREE.PlaneBufferGeometry(60, 20);
    var planeMaterial = new THREE.MeshBasicMaterial({ color: 0x3333ff });
}

function animate() {
    var delta = clock.getDelta();
    trackballControl.update(delta);
    //trackballControl.update(clock.getDelta());
    renderer.render( scene , camera );
    requestAnimationFrame(animate);
    composer.render(delta);
}

var guiShader = function() {
    //this.FilmPassOn = true;
    this.SepiaPassOn = true;
}

function createGui() {
    var shaderGUI = new guiShader();
    var gui = new dat.GUI();

    /*
    gui.add(shaderGUI, 'FilmPassOn')
        .name('FilmPass On/Off')
        .onChange((e)=>{
            effectFilm.renderToScreen = e;
    });
    */
    
    gui.add(shaderGUI, 'SepiaPassOn')
    .name('SepiaShader On/Off')
    .onChange((e)=>{
        sepiaShader.renderToScreen = e;
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