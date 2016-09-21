/// <binding Clean='clean' />
"use strict";

var gulp = require("gulp"),
    rimraf = require("rimraf"),
    concat = require("gulp-concat"),
    cssmin = require("gulp-cssmin"),
    uglify = require("gulp-uglify"),
    browserify = require("browserify"),
    source = require("vinyl-source-stream");

var webroot = "./wwwroot/";

var paths = {
    app: webroot + "js/app/*.js",
    js: webroot + "js/**/*.js",
    minJs: webroot + "js/**/*.min.js",
    build: webroot + "js/build.js",
    css: webroot + "css/**/*.css",
    minCss: webroot + "css/**/*.min.css",
    concatJsDest: webroot + "js/site.js",
    concatCssDest: webroot + "css/site.min.css",
    main: webroot + "js/app/app.js"
};

gulp.task("clean:js", function (cb) {
    rimraf(paths.concatJsDest, cb);
});

gulp.task("clean:css", function (cb) {
    rimraf(paths.concatCssDest, cb);
});

gulp.task("clean", ["clean:js", "clean:css"]);

gulp.task("min:js", function () {
    return gulp.src([paths.js, "!" + paths.minJs], { base: "." })
        .pipe(concat(paths.concatJsDest))
        .pipe(gulp.dest("."));
});





gulp.task("min:css", function () {
    return gulp.src([paths.css, "!" + paths.minCss])
        .pipe(concat(paths.concatCssDest))
        .pipe(cssmin())
        .pipe(gulp.dest("."));
});


gulp.task('build-app', function () {
    return browserify(paths.main)
        .bundle()
        .on("error", function (err) {
            console.log(err);
        })
        .pipe(source("site.js"))
        .pipe(gulp.dest(webroot + "js"));
});


gulp.task("min", ["min:js", "min:css"]);
gulp.task("build", ["build-app"]);
