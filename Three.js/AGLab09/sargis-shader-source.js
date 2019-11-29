var Shaders = {};

Shaders.BasicShader1 = {

    name: 'BasicShader1',

    uniforms: {    
    color1: {
        value: new THREE.Color("red")
      },
      color2: {
        value: new THREE.Color("lime") //green
      },
    },

    vertexShader:

    `varying vec2 vUv;
    void main(){

        vUv = uv;
        
        gl_Position = projectionMatrix * modelViewMatrix * vec4(position, 1.0);

    }`,

    fragmentShader:

    `varying vec2 vUv;

    uniform vec3 color1;
    uniform vec3 color2;

    void main(){

        gl_FragColor = vec4(mix(color1, color2, vUv.x), 1.0);

    }`
};

Shaders.BasicShader2 = {

    name: 'BasicShader2',

    uniforms: {    
    color1: {
        value: new THREE.Color("red")
      },
      color2: {
        value: new THREE.Color("lime") //green
      }},

    vertexShader:

    `varying vec2 vUv;
    void main(){

        vUv = uv;
        
        gl_Position = projectionMatrix * modelViewMatrix * vec4(position, 1.0);

    }`,

    fragmentShader:

    `varying vec2 vUv;

    uniform vec3 color1;
    uniform vec3 color2;
    
    void main(){

        gl_FragColor = vec4(mix(color1, color2, vUv.x), 1.0);

    }`
};

Shaders.BasicShader3 = {

    name: 'BasicShader4',

    uniforms: {
        'time': {type: 'f', value: 0},
        color1: {
            value: new THREE.Color("red")
          },
          color2: {
            value: new THREE.Color("lime") //green
          }
    },

    vertexShader:

    `uniform float time;
    varying vec2 vUv;
    void main(){

        vUv = uv;

        vec3 pos = position;

        pos.x += 3.0 * sin(time) * sin(pos.x);

        gl_Position = projectionMatrix * modelViewMatrix * vec4(pos, 1.0);

    }`,

    fragmentShader:

    `varying vec2 vUv;

    uniform vec3 color1;
    uniform vec3 color2;
    
    void main(){

        gl_FragColor = vec4(mix(color1, color2, vUv.x), 1.0);

    }`
};

Shaders.BasicShader4 = {

    name: 'BasicShader4',

    uniforms: {
        'time': {type: 'f', value: 0},
        color1: {
            value: new THREE.Color("red")
          },
          color2: {
            value: new THREE.Color("lime") //green
          }
    },

    vertexShader:

    `uniform float time;
    varying vec2 vUv;
    void main(){

        vUv = uv;

        vec3 pos = position;

        pos.z += 3.0 * sin(time) * sin(pos.x);

        gl_Position = projectionMatrix * modelViewMatrix * vec4(pos, 1.0);

    }`,

    fragmentShader:

    `varying vec2 vUv;

    uniform vec3 color1;
    uniform vec3 color2;
    
    void main(){

        gl_FragColor = vec4(mix(color1, color2, vUv.x), 1.0);

    }`
};