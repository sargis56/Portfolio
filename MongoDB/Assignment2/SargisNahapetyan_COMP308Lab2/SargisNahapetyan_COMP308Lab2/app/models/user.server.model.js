// Load the Mongoose module and Schema object
var mongoose = require('mongoose'),
    Schema = mongoose.Schema;
// Define a new 'UserSchema'
var UserSchema = new Schema({
    firstName: String,
    lastName: String,
    email: String,
    password: String,
    fs: String,
    ft: String,
    feedback: String
});
// Create the 'User' model out of the 'UserSchema'
mongoose.model('User', UserSchema);