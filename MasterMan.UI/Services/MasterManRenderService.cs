﻿using MasterMan.Core.Services;
using RenderService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace MasterMan.UI.Services
{
    public class MasterManRenderService
    {
        private RenderService.Services.RenderService render;
        public MasterManRenderService(Canvas canvas, string textureUri, int tileSize, int mapSize)
        {
            render = new RenderService.Services.RenderService(canvas, textureUri, tileSize, mapSize);
        }

        public void SetBackgroundColor(Color color)
        {
            render.SetBackgroundColor(color);
        }

        public void Render()
        {
            List<GraphicNode> tree = SceneManager.Instance.GetUpdatedTree();
            render.Render(tree);
        }
    }
}
