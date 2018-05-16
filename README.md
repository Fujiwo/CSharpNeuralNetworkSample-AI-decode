# CSharpNeuralNetworkSample-AI-decode
neural network sample in C# for Microsoft de:code 2018 AI sessions

C# �Ńj���[�����l�b�g���[�N���t���X�N���b�`�ŏ����ċ@�B�w�K�̌����𗝉����悤

### �T�v:


Microsoft [de:code 2018](https://www.microsoft.com/ja-jp/events/decode/2018/) �Œ񋟂����T���v�� �R�[�h�ł��B
���̃Z�b�V�����Ő������܂��B

* [AI61 C# �Ńj���[�����l�b�g���[�N���X�N���b�`�ŏ����ċ@�B�w�K�̌����𗝉����悤](https://www.event-marketing.jp/events/decode/2018/sess/Schedule_Detail.aspx?id=AI61&url=Schedule.aspx)
(2018/05/22 16:45 - 17:00)

C# �ŋ@�B�w�K�̌����ł���j���[�����l�b�g���[�N���t���X�N���b�`�ŏ����Ă݂�T���v�� �R�[�h�Ɛ����ł��B

�j���[�����l�b�g���[�N���������Ă݂邱�ƂŁA�@�B�w�K�̊�b��������Ɨ����ł��܂��B�@�B�w�K����b���痝�����邱�Ƃ�ړI�Ƃ��Ă��܂��B

### �v���W�F�N�g:

#### NeuralNetwork.Core

�@�B�w�K (Machine Learning) �̃R�A�ƂȂ镔���ł��B

C# �ŏ����̃j���[��������Ȃ鏬�K�͂ȃj���[���� �l�b�g���[�N���쐬���Ă��܂��B
�j���[��������̏o�͂ɂ́A�V�O���C�h�֐����g���܂��B

##### ���O��� (namespace) - NeuralNetwork.Core

| �\�[�X �R�[�h | �N���X | ���� |
| --- | --- | --- |
| NeuralNetwork.cs | EnumerableExtension | �ėp�g�����\�b�h |
| | Math | ���w |
| | Input | ���� |
| | Neuron | �j���[���� |
| | NeuralNetwork | �j���[���� �l�b�g���[�N |

#### NeuralNetworkSample.WPF

��L�j���[���� �l�b�g���[�N���g�p�����T���v���ł��B

���䌧�Ƃ��̎��ӂ̎��ۂ̍��W��p���ď�L�j���[���� �l�b�g���[�N���P�����܂��B

���t�f�[�^�́A"locations.csv" �ŁA�n���A�ܓx�A�o�x�A���䌧�����ǂ����A����Ȃ� 1,088�_�̍��W�f�[�^�ł��B

�P����̃j���[���� �l�b�g���[�N�ɁA�e�X�g�p�̍��W�f�[�^����͂��A���䌧�̒��̍��W���ǂ����𔻒肳���Ă��܂��B

�\��������͈̂ȉ��̂��̂ł��B

* �V�O���C�h�֐��̃O���t
* �S���W�f�[�^�̃v���b�g
* �P���O�̃j���[���� �l�b�g���[�N�ɂ�锻�茋��
* ���t�f�[�^
* ���t�f�[�^�ŌP����̃j���[���� �l�b�g���[�N�ɂ�锻�茋��

���̃v���O������ WPF �ō���Ă���AMVVM (Model-View-ViewModel) �p�^�[���ō\������Ă��܂��B

##### ���O��� (namespace) - NeuralNetworkSample.WPF.Models

���f��

| �\�[�X �R�[�h | �N���X | ���� |
| --- | --- | --- |
| Model.cs | Coordinate | �n���A�ܓx�A�o�x���܂ލ��W |
| | MathModel | ���w���f�� |
| | DataModelBase | �f�[�^ ���f���̃x�[�X �N���X |
| | SampleDataModel | ���W�f�[�^ ���f�� |
| | NeuralNetworkModel | �P���O�̃f�[�^ ���f�� |
| | TrainingDataModel | ���t�f�[�^ ���f�� |
| | MachineLearningModel | ���t�f�[�^�ŋ@�B�w�K��̃��f�� |

##### ���O��� (namespace) - NeuralNetworkSample.WPF.ViewModels

�r���[���f��

| �\�[�X �R�[�h | �N���X | ���� |
| --- | --- | --- |
| MainWindowViewModel.cs | LineSeriesViewModel | �v���b�g�p |
| | MathViewModel | �V�O���C�h�֐��\���p |
| | SampleDataViewModel | ���W�f�[�^�\���p |
| | NeuralNetworkViewModel | �P���O�̃f�[�^�\���p |
| | TrainingDataViewModel | ���t�f�[�^�\���p |
| | MachineLearningViewModel | ���t�f�[�^�ŋ@�B�w�K��̕\���p |
| | MainWindowViewModel | ���C����ʑS�̂� ViewModel |

##### ���O��� (namespace) - NeuralNetworkSample.WPF.View

�r���[

| �\�[�X �R�[�h | �N���X | ���� |
| --- | --- | --- |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.Views | MainWindow.xaml | MainWindow | ���C����� |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.Views | MainWindow.xaml.cs | MainWindow | ���C����� |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF | App.xaml | App | �A�v���P�[�V���� |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF | App.xaml.cs | App | �A�v���P�[�V���� |
| NeuralNetworkSample.WPF |  | locations.csv |  | ���W�f�[�^ �t�@�C�� (csv) |

##### ���O��� (namespace) - NeuralNetworkSample.WPF.View

�r���[

| �\�[�X �R�[�h | �N���X | ���� |
| --- | --- | --- |
| MainWindow.xaml | MainWindow | ���C����� |
| MainWindow.xaml.cs | MainWindow | ���C����� |

##### ���O��� (namespace) - NeuralNetworkSample.WPF

| �\�[�X �R�[�h | �N���X | ���� |
| --- | --- | --- |
| App.xaml | App | �A�v���P�[�V���� |
| App.xaml.cs | App | �A�v���P�[�V���� |

##### �f�[�^ �t�@�C��

| �t�@�C���� | ���� |
| --- | --- |
| locations.csv | ���W�f�[�^ �t�@�C�� (csv) |

### ��������:

![C# �Ńj���[�����l�b�g���[�N���X�N���b�`�ŏ������@�B�w�K�̌����𗝉����悤](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(01).png "C# �Ńj���[�����l�b�g���[�N���X�N���b�`�ŏ������@�B�w�K�̌����𗝉����悤")
![�@�B�w�K (Machine Learning) �Ƃ�](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(02).png "�@�B�w�K (Machine Learning) �Ƃ�")
![�܂� �l�H�m�\ (Artificial Intelligence) �Ƃ�](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(03).png "�܂� �l�H�m�\ (Artificial Intelligence) �Ƃ�")
![�@�B�w�K�Ƃ�](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(04).png "�@�B�w�K�Ƃ�")
![�@�B�w�K�̎��](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(05).png "�@�B�w�K�̎��")
![�f�B�[�v���[�j���O (�[�w�w�K: Deep Learning)](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(06).png "�f�B�[�v���[�j���O (�[�w�w�K: Deep Learning)")
![�f�B�[�v ���[�j���O](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(07).png "�f�B�[�v ���[�j���O")
![�l�H�m�\�Ƌ@�B�w�K](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(08).png "�l�H�m�\�Ƌ@�B�w�K")
![�j���[���� �l�b�g���[�N�Ƃ�](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(09).png "�j���[���� �l�b�g���[�N�Ƃ�")
![�_�o�זE�̃l�b�g���[�N](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(10).png "�_�o�זE�̃l�b�g���[�N")
![�j���[���� �l�b�g���[�N](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(11).png "�j���[���� �l�b�g���[�N")
![�X�̃j���[����](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(12).png "�X�̃j���[����")
![�V�O���C�h�֐�](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(13).png "�V�O���C�h�֐�")
![�j���[���� �l�b�g���[�N�ɂ�镪��](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(14).png "�j���[���� �l�b�g���[�N�ɂ�镪��")
![����쐬����j���[���� �l�b�g���[�N](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(15).png "����쐬����j���[���� �l�b�g���[�N")
![����̃j���[���� �l�b�g���[�N�̌P��](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(16).png "����̃j���[���� �l�b�g���[�N�̌P��")
![�P���O�̏d�݂̒l](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(17).png "�P���O�̏d�݂̒l")
![�P����̏d�݂̒l](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(18).png "�P����̏d�݂̒l")

---

### �֘A����:

* [PredictStockPrice-AI-decode](https://github.com/Fujiwo/PredictStockPrice-AI-decode):
neural network sample in C# for Microsoft de:code 2018 AI sessions ([Microsoft Azure Machine Learning Studio](https://studio.azureml.net) �ɂ�銔���\�z�v���O����)

---
