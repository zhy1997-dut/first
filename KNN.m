function labelMat = KNN(inx,data,labels,k)
%% 
%   inx 为 输入测试数据，data为样本数据，labels为样本标签
%%
[inxrow,~]=size(inx);
[datarow , ~] = size(data);
labelMat=zeros(inxrow,1);
for i=1:inxrow
    distanceMat=zeros(datarow,1);
    for j=1:datarow
        distance=dtw(inx(i,:),data(j,:));
        distanceMat(j)=distance;
    end
    [B , IX] = sort(distanceMat,'ascend');
    len = min(k,length(B));
    label = mode(labels(IX(1:len)));
    labelMat(i)=label;
end

end
