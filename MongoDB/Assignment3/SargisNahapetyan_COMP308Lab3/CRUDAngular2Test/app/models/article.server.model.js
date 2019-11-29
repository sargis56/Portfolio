const mongoose = require('mongoose');
const Schema = mongoose.Schema;
const ArticleSchema = new Schema({
    created: {
        type: Date,
        default: Date.now
    },
    code: {
        type: Number,
        default: 1,
        trim: true,
        required: 'Course code cannot be blank'
    },
    name: {
        type: String,
        default: '',
        trim: true,
        required: 'Course name cannot be blank'
    },
    section: {
        type: Number,
        default: 1,
        trim: true,
        required: 'Course section cannot be blank'
    },
    semester: {
        type: Number,
        default: 1,
        trim: true,
        required: 'Course semester cannot be blank'
    },
    creator: {
        type: Schema.ObjectId,
        ref: 'User'
    }
});
mongoose.model('Article', ArticleSchema);
