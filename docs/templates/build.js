// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

const esbuild = require('esbuild')
const { sassPlugin } = require('esbuild-sass-plugin')
const bs = require('browser-sync')
const { cpSync, rmSync } = require('fs')
const { join } = require('path')
const { spawnSync } = require('child_process')
const yargs = require('yargs/yargs')
const { hideBin } = require('yargs/helpers')
const argv = yargs(hideBin(process.argv)).argv

const watch = argv.watch
const project = argv.project || '../samples/seed'
const distdir = '../src/Docfx.App/templates'

const loader = {
  '.eot': 'file',
  '.svg': 'file',
  '.ttf': 'file',
  '.woff': 'file',
  '.woff2': 'file'
}

build()

async function build() {

  await buildRedFoxDocumentDbEventingTemplate();

  copyToDist()

  if (watch) {
    serve()
  }
}

async function buildRedFoxDocumentDbEventingTemplate() {
  const config = {
    bundle: true,
    format: 'esm',
    splitting: true,
    minify: true,
    sourcemap: true,
    outExtension: {
      '.css': '.min.css',
      '.js': '.min.js'
    },
    outdir: 'redfox-documentdb/public',
    entryPoints: [
      'redfox-documentdb/src/docfx.ts',
      'redfox-documentdb/src/search-worker.ts',
    ],
    plugins: [
      sassPlugin()
    ],
    loader,
  }

  if (watch) {
    const context = await esbuild.context(config)
    await context.watch()
  } else {
    await esbuild.build(config)
  }
}


function copyToDist() {

  rmSync(distdir, { recursive: true, force: true })

  cpSync('redfox-documentdb', join(distdir, 'redfox-documentdb'), { recursive: true, overwrite: true, filter })

  function filter(src) {
    const segments = src.split(/[/\\]/)
    return !segments.includes('node_modules') && !segments.includes('package-lock.json') && !segments.includes('src')
  }

  function staticTocFilter(src) {
    return filter(src) && !src.includes('toc.html')
  }
}
